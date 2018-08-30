using ETModel;
using UnityEngine;


namespace ETHotfix
{
	[UIFactory(UIType.FGUITest)]
	public class FGUITestFactory : IUIFactory
	{
		public UI Create(Scene scene, string type, GameObject parent)
		{
			//TODO

			Log.Debug("FairyGUI.UIPackage.AddPackage(Bag);");

			FairyGUI.UIPackage.AddPackage("FGUI/Bag");

			UI ui = ComponentFactory.Create<UI, GameObject>(null);
			ui.AddComponent<FGUITestComponent>();
			return ui;
		}

		public void Remove(string type)
		{
			//TODO
			//FairyGUI.UIPackage.RemovePackage("FGUI/Bag");
		}
	}
}