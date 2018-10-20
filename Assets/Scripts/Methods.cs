using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Methods {
	public static bool result;
	public static string comboForCheck;
	public static int index = 0;
	public static void ComboLineToString()
	{
		comboForCheck = "";
		foreach(int i in Combat.comboLine)
		{
			comboForCheck += i.ToString();
		}
	}

	public static void ComboChecker()
	{
		while(result == false && index < 4)
		{
			foreach(string i in Combat.comboList)
			{
				result = comboForCheck.Equals(Combat.comboList[index]);
				index ++;
			}
		}
	}

	public static void DebugComboChecker()
	{
		if(result == true)
		{
			Debug.Log("NICE COMBO");
		}

		if(result == false)
		{
			Debug.Log("NOT NICE COMBO");
		}
	}

	public static void CombosLoad()
	{
		Combos deepBreath = new Combos("Deep Breath", "111", 3);
		Combos rollout = new Combos("Rollout", "121", 2);
		Combos upperCut = new Combos("Uppercut", "123", 0);
		Combos flyingKick = new Combos("Flying Kick", "224", 2);

		Combat.comboList.Add(deepBreath.code);
		Combat.comboList.Add(rollout.code);
		Combat.comboList.Add(upperCut.code);
		Combat.comboList.Add(flyingKick.code);
	}

	public static void MainLoad()
	{
		Combat.actions.Add(1);
		Combat.actions.Add(2);
		Combat.actions.Add(3);
		Combat.actions.Add(4);
	}

	public static void DebugLogs()
	{
		foreach(int i in Combat.actions)
		{
			Debug.Log(i);
		}
	}

	public static void ComboLineLength()
	{
		if(Combat.comboLine.Count > 7)
		{
			Combat.comboLine.Clear();
		}
	}

}
