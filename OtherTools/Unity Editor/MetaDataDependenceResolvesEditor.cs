using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

/// <summary>
/// @author Kimi
/// 查找 prefab 依赖 Atlas, 获得使用到 Atlas.Sprite 对象名称，方便更换
/// </summary>
public class MetaDataDependenceResolvesEditor : EditorWindow
{
	[MenuItem("Tools/MetaData/Simple/DependenceResolvesEditor")]
	static void OpenEditor()
	{
		var window = EditorWindow.GetWindow<MetaDataDependenceResolvesEditor>(false, "MetaDataDependenceResolvesEditor");
		window.Show();
	}


	GameObject needFindGameObject;
	GameObject dependenceAtlasGameObject;
	string resolvesTextContent = "";

	private void OnGUI()
	{
		needFindGameObject = (GameObject)EditorGUILayout.ObjectField("需要查找的 xxxx.prefab：", needFindGameObject, typeof(GameObject), true);
		dependenceAtlasGameObject = (GameObject)EditorGUILayout.ObjectField("查找的依赖 Atlas.prefab：", dependenceAtlasGameObject, typeof(GameObject), true);

		if (GUILayout.Button("解析依赖 Atlas 内容，获得 AtlasSpriteName 和 使用到的对象名称"))
		{
			resolvesTextContent = string.Empty;

			if (needFindGameObject && dependenceAtlasGameObject)
			{
				var assetPath1 = AssetDatabase.GetAssetPath(needFindGameObject);
				var assetPath2 = AssetDatabase.GetAssetPath(dependenceAtlasGameObject);

				string needFindContent = string.Empty;
				string dependencePrefabContent = string.Empty;

				StreamReader streamReader1 = new StreamReader(assetPath1);//需要查找的 xxx.prefab
				if (streamReader1 != null)
				{
					needFindContent = streamReader1.ReadToEnd();
				}
				StreamReader streamReader2 = new StreamReader(assetPath2 + ".meta");//查找目标依赖Atlas文件 xxx.mate
				if (streamReader2 != null)
				{
					dependencePrefabContent = streamReader2.ReadToEnd();
				}
				InitParse(needFindContent, dependencePrefabContent);
			}
			else
			{
				ShowNotification(new GUIContent("请拖动需要的查找的内容~~~"));
			}
		}

		GUILayout.Label("解析内容:");
		GUILayout.TextArea(resolvesTextContent, GUILayout.Height(200));
	}

	List<MetaData> gameObjectMataDatas = new List<MetaData>();
	List<MetaData> monoBehaviourMataDatas = new List<MetaData>();

	void InitParse(string needFindContent, string dependencePrefabContent)
	{
		gameObjectMataDatas.Clear();
		monoBehaviourMataDatas.Clear();

		//解析查找.prefab文件信息
		if (!string.IsNullOrEmpty(needFindContent))
		{
			string text = needFindContent;
			string[] textArray = text.Split(new string[] { "---" }, StringSplitOptions.None);

			foreach (var v in textArray)
			{
				if (v.Contains("MonoBehaviour:"))
				{
					var mataData = new MetaData();
					mataData.SetData(v);
					monoBehaviourMataDatas.Add(mataData);
				}
				else if (v.Contains("GameObject:"))
				{
					var mataData = new MetaData();
					mataData.SetData(v);
					gameObjectMataDatas.Add(mataData);
				}
			}
		}

		//解析查找 xxx.prefab 文件的依赖的文件 Atlas.prefab 的 Atlas.prefab.meta 的 GUID 信息
		string dependenceAtlasGUID = string.Empty;
		if (!string.IsNullOrEmpty(dependencePrefabContent))
		{
			string text = dependencePrefabContent;
			string[] textArray = text.Split(new string[] { "\n" }, StringSplitOptions.None);

			foreach (var v in textArray)
			{
				if (v.Contains("guid:"))
				{
					dependenceAtlasGUID = v.Split(new string[] { ":" }, StringSplitOptions.None)[1].Trim();
					break;
				}
			}
		}

		//通过dependenceTextAssetGUID查找GameObject fileID
		List<string> gameObjectFileID = new List<string>();
		Dictionary<string, string> spriteNameWithFileID = new Dictionary<string, string>();
		foreach (var v in monoBehaviourMataDatas)
		{
			if (v.m_GUID == dependenceAtlasGUID)
			{
				gameObjectFileID.Add(v.m_GameObjectFileID);
				spriteNameWithFileID[v.m_GameObjectFileID] = v.m_SpriteName;
			}
		}

		//再通过查找与 fileID 相同的GameObject Name 对象
		List<MetaData> list = new List<MetaData>();
		foreach (var v in gameObjectMataDatas)
		{
			if (gameObjectFileID.Contains(v.m_FlagID))
			{
				var info = string.Format("m_SpriteName: {0} \t\t m_Name: {1}\n", spriteNameWithFileID[v.m_FlagID], v.m_Name);
				resolvesTextContent += info;
				Debug.Log(info);
			}
		}
	}
}

/// <summary>
/// 解析.prefab需要的数据
/// </summary>
class MetaData
{
	public string content = string.Empty;

	public bool isMonoBehaviour = false;

	public string m_FlagID = string.Empty;

	//GameObject:
	public string m_Name = string.Empty;

	//MonoBehaviour:
	public string m_GUID = string.Empty;
	public string m_SpriteName = string.Empty;
	public string m_GameObjectFileID = string.Empty;


	public void SetData(string content)
	{
		this.content = content;
		Parse();
	}

	void Parse()
	{
		string[] textArray = content.Split(new string[] { "\n" }, StringSplitOptions.None);

		for (int i = 1; i < textArray.Length; ++i)
		{
			var v = textArray[i];

			if (i == 1)
			{
				//--- !u!1 &115510
				m_FlagID = textArray[0].Split(new string[] { "&" }, StringSplitOptions.None)[1].Trim();
				if (v.IndexOf("MonoBehaviour:") != -1)
				{
					isMonoBehaviour = true;
				}
				continue;
			}

			if (isMonoBehaviour)
			{
				if (v.IndexOf("m_GameObject:") != -1)
				{
					//m_GameObject: { fileID: 115510}
					m_GameObjectFileID = v.Substring(v.IndexOf("{")).Split(new string[] { ":" }, StringSplitOptions.None)[1].Replace("}", "").Trim();
				}
				else if (v.Contains("mAtlas:"))
				{
					//mAtlas: { fileID: 11490166, guid: beccce426c090414392204d6c43d534b, type: 2}
					if (v.IndexOf("guid:") != -1)
					{
						m_GUID = v.Substring(v.IndexOf("{")).Split(new string[] { "," }, StringSplitOptions.None)[1].Split(new string[] { ":" }, StringSplitOptions.None)[1].Trim();
					}
				}
				else if (v.IndexOf("mSpriteName:") != -1)
				{
					//mSpriteName: ui_csd0003_01
					m_SpriteName = v.Split(new string[] { ":" }, StringSplitOptions.None)[1].Trim();
				}
			}
			else
			{
				if (v.IndexOf("m_Name:") != -1)
				{
					//m_Name: Sprite
					m_Name = v.Split(new string[] { ":" }, StringSplitOptions.None)[1].Trim();
				}
			}
		}
	}
}
