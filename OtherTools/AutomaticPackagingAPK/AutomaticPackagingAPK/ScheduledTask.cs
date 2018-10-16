using System;
using System.Collections.Generic;
using System.Diagnostics;

/// <summary>
/// 自动化打包 APK
/// </summary>
namespace AutomaticPackagingAPK
{
	/// <summary>
	/// 计划任务
	/// </summary>
	class ScheduledTask
	{
		static void Main(string[] args)
		{
			List<string> argsList = new List<string>(args);
			string filePathName = argsList[argsList.Count - 1];
			while (true)
			{
				string nowTimeStr = string.Format("{0}:{1}", DateTime.Now.Hour.ToString(), DateTime.Now.Minute.ToString());
				if (argsList.Contains(nowTimeStr))
				{
					Process proc = new Process();
					proc.StartInfo.FileName = filePathName;
					proc.Start();
				}
				System.Threading.Thread.Sleep(10000);
			}
		}
	}
}
