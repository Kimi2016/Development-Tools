using UnityEngine;


namespace ETHotfix
{
	public class FGUITestFactory : IUIFactory
	{
		public UI Create(Scene scene, string type, GameObject parent)
		{
			//TODO

			Log.Debug("FairyGUI.UIPackage.AddPackage(Bag);");
			FairyGUI.UIPackage.AddPackage("FGUI/Bag");
			FairyGUI.GComponent gComponent = FairyGUI.UIPackage.CreateObject("Bag", "Main").asCom;
			FairyGUI.GRoot.inst.AddChild(gComponent);

			gComponent.GetChild("bagBtn").onClick.Add(() =>
			{
				var component = FairyGUI.UIPackage.CreateObject("Bag", "BagWin").asCom;
				FairyGUI.GRoot.inst.AddChild(component);
			});

			return null;
		}

		public void Remove(string type)
		{
			//TODO
		}
	}
}