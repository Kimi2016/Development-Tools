
using ETModel;

namespace ETHotfix
{
	[Event(EventIdType.FGUITest)]
	public class FGUITestEvent : AEvent
	{
		public override void Run()
		{
			UI ui = Game.Scene.GetComponent<FGUIComponent>().Create(UIType.FGUITest);
		}
	}
}