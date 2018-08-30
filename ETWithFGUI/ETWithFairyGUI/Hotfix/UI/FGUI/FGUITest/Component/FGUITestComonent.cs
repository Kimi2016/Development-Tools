using UnityEngine;
using ETModel;

namespace ETHotfix
{
	[ObjectSystem]
	public class FGUITestComonentSystem : AwakeSystem<FGUITestComonent>
	{
		public override void Awake(FGUITestComonent self)
		{
			self.Awake();
		}
	}

	public class FGUITestComonent : Component
	{
		public void Awake()
		{

		}
	}
}