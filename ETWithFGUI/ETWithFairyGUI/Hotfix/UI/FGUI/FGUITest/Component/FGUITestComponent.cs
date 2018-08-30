using UnityEngine;
using ETModel;
using System;

namespace ETHotfix
{
	[ObjectSystem]
	public class FGUITestComponentSystem : AwakeSystem<FGUITestComponent>
	{
		public override void Awake(FGUITestComponent self)
		{
			self.Awake();
		}
	}

	public class FGUITestComponent : Component
	{
		public void Awake()
		{
			Log.Debug("FGUITestComonent.Awake()");

			FairyGUI.GComponent gComponent = FairyGUI.UIPackage.CreateObject("Bag", "Main").asCom;

			if (gComponent != null)
			{
				FairyGUI.GRoot.inst.AddChild(gComponent);
				gComponent.GetChild("bagBtn").onClick.Add(OnLogin);
			}
		}

		public async void OnLogin()
		{
			try
			{
				var component = FairyGUI.UIPackage.CreateObject("Bag", "BagWin").asCom;
				FairyGUI.GRoot.inst.AddChild(component);
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}
	}
}