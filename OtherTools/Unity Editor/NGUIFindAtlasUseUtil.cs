using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
 
public class NGUIFindAtlasUseUtil : EditorWindow
{
    static NGUIFindAtlasUseUtil window;

    UIAtlas atlas;
    Transform[] selectTrans;
    List<UISprite> spriteList;
    Vector2 scrollPosition;
    List<UIAtlas> atlasList = new List<UIAtlas>();
    bool selectedAtlas = true;

    //位置调整
    int adjustPosition = 30;
    //可查多路径下图集
    string atlasPathString = "Assets/NGUI/Examples;Assets/NGUI/Resources";

    string[] atlasPath = new string[] {};

    [MenuItem("Tools/查找NGUI图集引用")]
    static void CreateWindow()
    {
        window = (NGUIFindAtlasUseUtil)EditorWindow.GetWindowWithRect<NGUIFindAtlasUseUtil>(new Rect(0,0,700, 500), false, "查找图集引用");
        window.Show();
    }

    private void OnEnable()
    {
        spriteList = new List<UISprite>();
    }

    private void OnGUI()
    {
        EditorGUILayout.Space();
        EditorGUILayout.Space();

        atlasPathString = EditorGUILayout.TextField("输入图集路径：", atlasPathString);

        EditorGUILayout.Space();
        EditorGUILayout.Space();
        atlas = EditorGUILayout.ObjectField("需要查询的图集：", atlas, typeof(UIAtlas), true) as UIAtlas;

        if (GUILayout.Button("显示图集"))
        {
            atlasPath = atlasPathString.Split(';');
            OnClickChooseAtlas();
        }

        if (selectedAtlas)
        {
            ShowChooseAtlas();
        }
        else
        {
            EditorGUILayout.Space();
            EditorGUILayout.Space();

            GUILayout.Label("可多选“Hierarchy”、“Project”面板的预设体");
            if (GUILayout.Button("查找引用"))
            {
                OnClickFindUse();
            }

            if (spriteList.Count > 0 && atlas)
            {
                ShowFindUseSprite();
            }
        }
    }

    void OnClickChooseAtlas()
    {
        selectedAtlas = true;

        //重置
        atlasList.Clear();
        spriteList.Clear();

        //第二个参数为图集的目录位置数组，可以指定项目里存放图集的父节点。切记不要在Assets节点下查找，这样会遍历所有物体，会很卡的~~
        string[] guids = AssetDatabase.FindAssets("t:Prefab", atlasPath);
        List<string> paths = new List<string>();
        guids.ToList().ForEach(m => paths.Add(AssetDatabase.GUIDToAssetPath(m)));
        paths.ForEach(p => atlasList.Add(AssetDatabase.LoadAssetAtPath(p, typeof(UIAtlas)) as UIAtlas));
        
        //移除Null值
        for (int i = 0; i < atlasList.Count; i++)
        {
            if (i < atlasList.Count && atlasList[i] == null)
            {
                atlasList.Remove(atlasList[i]);
                i--;
            }
        }
    }

    void OnClickFindUse()
    {
        selectTrans = Selection.GetTransforms(SelectionMode.TopLevel);

        if (selectTrans.Length == 0)
        {
            ShowNotification(new GUIContent("请选择查找：“Hierarchy”、“Project”面板的预设体"));
            return;
        }

        spriteList = new List<UISprite>();
        for (int i = 0; i < selectTrans.Length; i++)
        {
            UISprite[] sprites = selectTrans[i].GetComponentsInChildren<UISprite>(true);
            for (int j = 0; j < sprites.Length; j++)
            {
                if (sprites[j] != null && sprites[j].atlas == atlas)
                {
                    spriteList.Add(sprites[j]);
                }
            }
        }
    }

    //显示图集
    void ShowChooseAtlas()
    {
        scrollPosition = GUI.BeginScrollView(new Rect(0, adjustPosition + 60, Screen.width, 500), scrollPosition, new Rect(0, adjustPosition + 60, Screen.width, atlasList.Count * 20));
        for (int i = 0; i < atlasList.Count; i++)
        {
            atlasList[i] = EditorGUI.ObjectField(new Rect(5, adjustPosition + 60 + i * 25, Screen.width - 70, 20), name, atlasList[i], typeof(UIAtlas), true) as UIAtlas;
            if (GUI.Button(new Rect(Screen.width - 60, adjustPosition + 60 + i * 25, 50, 20), "Select"))
            {
                atlas = atlasList[i];
                selectedAtlas = false;
            }
        }
        GUI.EndScrollView();
    }

    //显示查找的图集引用
    void ShowFindUseSprite()
    {
        scrollPosition = GUI.BeginScrollView(new Rect(0, adjustPosition + 110, Screen.width, 500), scrollPosition, new Rect(0, adjustPosition + 110, Screen.width, spriteList.Count * 20));
        for (int i = 0; i < spriteList.Count; i++)
        {
            string name = spriteList[i].atlas != null ? spriteList[i].atlas.name : "空图集";
            name += " " + spriteList[i].spriteName;
            spriteList[i] = EditorGUI.ObjectField(new Rect(0, adjustPosition + 110 + i * 20, Screen.width, 20), name, spriteList[i], typeof(UISprite), true) as UISprite;

        }
        GUI.EndScrollView();
    }
}