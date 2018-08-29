using System.IO;
using UnityEditor;
using UnityEngine;

/// <summary>
/// @author Kimi
/// MenuItemTools
/// </summary>
public class MenuItemTools
{

	[MenuItem("Assets/GetSelectDirectoriesDependeniesFile", false, 54)]
	static void GetDirectoriesDependeniesFile()
	{
		string filePath = string.Empty;
		Object[] objects = Selection.GetFiltered(typeof(Object), SelectionMode.DeepAssets);
		foreach (var obj in objects)
		{
			if (obj.GetType() != typeof(GameObject))
			{
				continue;
			}
			
			var assetPath = AssetDatabase.GetAssetPath(obj);
			string[] dependenciesPaths = AssetDatabase.GetDependencies(assetPath);
			string pathNames = string.Empty;

			for (int i = 0; i < dependenciesPaths.Length; ++i)
			{
				if (dependenciesPaths[i].EndsWith(".png"))
					pathNames += "\t\t" + dependenciesPaths[i];
			}

			if (!string.IsNullOrEmpty(pathNames))
			{
				filePath += obj.name + "\n";
				filePath += pathNames;
				filePath += "\n\n";
			}
		}

		string outPath = string.Empty;
		outPath = Application.dataPath.Replace("Assets", "") + "DependeniesFile.txt";

		if (System.IO.Directory.Exists(outPath))
		{
			System.IO.Directory.Delete(outPath);
		}

		StreamWriter streamWriter = new StreamWriter(outPath);
		streamWriter.Write(filePath);
		streamWriter.Flush();
		streamWriter.Close();
		Debug.Log(filePath);
	}
}
