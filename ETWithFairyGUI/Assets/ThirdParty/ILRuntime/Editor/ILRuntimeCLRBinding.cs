#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using System;
using System.Text;
using System.Collections.Generic;
using System.Reflection;
using ILRuntime.Runtime.Enviorment;
//using ETModel;
using FairyGUI;
using UnityEngine.Playables;

[System.Reflection.Obfuscation(Exclude = true)]
public class ILRuntimeCLRBinding
{
    [MenuItem("Tools/ILRuntime/Generate CLR Binding Code")]
    static void GenerateCLRBinding()
    {
		List<Type> types = new List<Type>
		{
			typeof(int),
			typeof(float),
			typeof(long),
			typeof(object),
			typeof(string),
			typeof(Array),
			typeof(Vector2),
			typeof(Vector3),
			typeof(Quaternion),
			typeof(GameObject),
			typeof(UnityEngine.Object),
			typeof(Transform),
			typeof(RectTransform),
			typeof(Time),
			typeof(Debug),
			typeof(PlayState),

			//FairyGUI
			typeof(EventContext),
			typeof(EventDispatcher),
			typeof(EventListener),
			typeof(InputEvent),
			typeof(DisplayObject),
			typeof(Container),
			typeof(Stage),
			typeof(FairyGUI.Controller),
			typeof(GObject),
			typeof(GGraph),
			typeof(GGroup),
			typeof(GImage),
			typeof(GLoader),
			typeof(GMovieClip),
			typeof(TextFormat),
			typeof(GTextField),
			typeof(GRichTextField),
			typeof(GTextInput),
			typeof(GComponent),
			typeof(GList),
			typeof(GRoot),
			typeof(GLabel),
			typeof(GButton),
			typeof(GComboBox),
			typeof(GProgressBar),
			typeof(GSlider),
			typeof(PopupMenu),
			typeof(ScrollPane),
			typeof(Transition),
			typeof(UIPackage),
			typeof(Window),
			typeof(GObjectPool),
			typeof(Relations),
			typeof(RelationType),
			typeof(Timers),
			typeof(GTween),
			typeof(GTweener),
			typeof(EaseType),
			typeof(TweenValue),
			//typeof(LuaUIHelper),
			//typeof(GLuaComponent),
			//typeof(GLuaLabel),
			//typeof(GLuaButton),
			//typeof(GLuaProgressBar),
			//typeof(GLuaSlider),
			//typeof(GLuaComboBox),
			//typeof(LuaWindow),

			//所有DLL内的类型的真实C#类型都是ILTypeInstance
			typeof(List<ILRuntime.Runtime.Intepreter.ILTypeInstance>)
		};

		ILRuntime.Runtime.CLRBinding.BindingCodeGenerator.GenerateBindingCode(types, "Assets/ThirdParty/ILRuntime/Generated");
		AssetDatabase.Refresh();
    }

    [MenuItem("Tools/ILRuntime/Generate CLR Binding Code by Analysis")]
    static void GenerateCLRBindingByAnalysis()
    {
        //用新的分析热更dll调用引用来生成绑定代码
        ILRuntime.Runtime.Enviorment.AppDomain domain = new ILRuntime.Runtime.Enviorment.AppDomain();
        using (System.IO.FileStream fs = new System.IO.FileStream("Assets/Res/Code/Hotfix.dll.bytes", System.IO.FileMode.Open, System.IO.FileAccess.Read))
        {
            domain.LoadAssembly(fs);
        }
        //Crossbind Adapter is needed to generate the correct binding code
        //ILHelper.InitILRuntime(domain);
        ILRuntime.Runtime.CLRBinding.BindingCodeGenerator.GenerateBindingCode(domain, "Assets/ThirdParty/ILRuntime/Generated");
	    AssetDatabase.Refresh();
	}

	[MenuItem("Tools/ILRuntime/Clear CLR Binding Code")]
	static void ClearCLRBinding()
	{
		if (System.IO.Directory.Exists("Assets/ThirdParty/ILRuntime/Generated"))
		{
			System.IO.Directory.Delete("Assets/ThirdParty/ILRuntime/Generated", true);
		}
	}
}
#endif
