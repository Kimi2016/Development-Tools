﻿using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	class GearXYValue
	{
		public float x;
		public float y;

		public GearXYValue(float x, float y)
		{
			this.x = x;
			this.y = y;
		}
	}

	/// <summary>
	/// Gear is a connection between object and controller.
	/// </summary>
	public class GearXY : GearBase, ITweenListener
	{
		Dictionary<string, GearXYValue> _storage;
		GearXYValue _default;
		GTweener _tweener;

		public GearXY(GObject owner)
			: base(owner)
		{
		}

		protected override void Init()
		{
			_default = new GearXYValue(_owner.x, _owner.y);
			_storage = new Dictionary<string, GearXYValue>();
		}

		override protected void AddStatus(string pageId, string value)
		{
			if (value == "-" || value.Length == 0) //历史遗留处理
				return;

			string[] arr = value.Split(',');
			if (pageId == null)
			{
				_default.x = int.Parse(arr[0]);
				_default.y = int.Parse(arr[1]);
			}
			else
				_storage[pageId] = new GearXYValue(int.Parse(arr[0]), int.Parse(arr[1]));
		}

		override public void Apply()
		{
			GearXYValue gv;
			if (!_storage.TryGetValue(_controller.selectedPageId, out gv))
				gv = _default;

			if (tween && UIPackage._constructing == 0 && !disableAllTweenEffect)
			{
				if (_tweener != null)
				{
					if (_tweener.endValue.x != gv.x || _tweener.endValue.y != gv.y)
					{
						_tweener.Kill(true);
						_tweener = null;
					}
					else
						return;
				}

				if (_owner.x != gv.x || _owner.y != gv.y)
				{
					if (_owner.CheckGearController(0, _controller))
						_displayLockToken = _owner.AddDisplayLock();

					_tweener = GTween.To(_owner.xy, new Vector2(gv.x, gv.y), tweenTime)
						.SetDelay(delay)
						.SetEase(easeType)
						.SetTarget(this)
						.SetListener(this);
				}
			}
			else
			{
				_owner._gearLocked = true;
				_owner.SetXY(gv.x, gv.y);
				_owner._gearLocked = false;
			}
		}

		public void OnTweenStart(GTweener tweener)
		{//nothing
		}

		public void OnTweenUpdate(GTweener tweener)
		{
			_owner._gearLocked = true;
			_owner.SetXY(tweener.value.x, tweener.value.y);
			_owner._gearLocked = false;

			_owner.InvalidateBatchingState();
		}

		public void OnTweenComplete(GTweener tweener)
		{
			_tweener = null;
			if (_displayLockToken != 0)
			{
				_owner.ReleaseDisplayLock(_displayLockToken);
				_displayLockToken = 0;
			}
			_owner.OnGearStop.Call(this);
		}

		override public void UpdateState()
		{
			GearXYValue gv;
			if (!_storage.TryGetValue(_controller.selectedPageId, out gv))
				_storage[_controller.selectedPageId] = new GearXYValue(_owner.x, _owner.y);
			else
			{
				gv.x = _owner.x;
				gv.y = _owner.y;
			}
		}

		override public void UpdateFromRelations(float dx, float dy)
		{
			if (_controller != null && _storage != null)
			{
				foreach (GearXYValue gv in _storage.Values)
				{
					gv.x += dx;
					gv.y += dy;
				}
				_default.x += dx;
				_default.y += dy;

				UpdateState();
			}
		}
	}
}
