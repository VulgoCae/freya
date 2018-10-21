using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Methods {

	public static bool result;
	public static string comboForCheck;
	public static int index = 0;
	public static bool checkerLock;
	public static int lastComboIndex;
	public static bool comboIsReady;
	
	public static void ConfirmCombo()
	{
		if(comboIsReady == true)
		{
			Debug.Log(Combat.comboList[lastComboIndex].name + " has been used!");
			ClearComboLine();
		}

		if(comboIsReady == false)
		{
			ClearComboLine();
		}
	}

	public static void ClearComboLine()
	{
		Combat.comboLine.Clear();
		Debug.Log("ComboLine has been cleared");
	}
	
	public static void ComboLineToString()
	{
		comboForCheck = null;
		foreach(int i in Combat.comboLine)
		{
			comboForCheck += i.ToString();
		}
	}

	public static void ComboChecker()
	{
		while(result == false && index < 4)
		{
			foreach(string i in Combat.comboListCode)
			{
				if(checkerLock == false)
				{
					result = comboForCheck.Equals(Combat.comboListCode[index]);
					if(result == true)
					{
						checkerLock = true;
						lastComboIndex = index;
					}
					index ++;
				}
			}
		}
		index = 0;
		checkerLock = false;
	}

	public static void ResultChecker()
	{
		if(result == false)
		{
			Debug.Log("NOT NICE COMBO");
		}
		if(result == true && Combat.comboList[lastComboIndex] != null)
		{
			Debug.Log("Combo " + Combat.comboList[lastComboIndex].name + " is ready!");
			comboIsReady = true;
			result = false;

		}

	}

	public static void CombosLoad()
	{
		Combos deepBreath = new Combos("Deep Breath", "111", 3);
		Combos rollout = new Combos("Rollout", "121", 2);
		Combos upperCut = new Combos("Uppercut", "123", 0);
		Combos flyingKick = new Combos("Flying Kick", "224", 2);

		Combat.comboList.Add(deepBreath);
		Combat.comboList.Add(rollout);
		Combat.comboList.Add(upperCut);
		Combat.comboList.Add(flyingKick);

		Combat.comboListCode.Add(deepBreath.code);
		Combat.comboListCode.Add(rollout.code);
		Combat.comboListCode.Add(upperCut.code);
		Combat.comboListCode.Add(flyingKick.code);

		Combat.actions.Add(1);
		Combat.actions.Add(2);
		Combat.actions.Add(3);
		Combat.actions.Add(4);
	}

	public static void DebugLogs()
	{
		/* foreach(int i in Combat.actions)
		{
			Debug.Log(i);
		}*/
	}

	public static void ComboLineLength()
	{
		if(Combat.comboLine.Count > 7)
		{
			Combat.comboLine.Clear();
		}
	}

}
