
using ETModel;

namespace ETHotfix
{
	[Event(EventIdType.FGUITest)]
	public class FGUITestEvent : AEvent
	{
		public override void Run()
		{
			Game.Scene.GetComponent<FGUIComponent>().Create(UIType.FGUITest);
		}
	}
}