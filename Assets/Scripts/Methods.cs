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
	public static int monsterIndex;


	public static void HPChecker(GameObject obj, GameObject enemy)
	{
		Debug.Log("monster hp:" + Avatar.monsterList[Methods.monsterIndex].hpNow);
		if(Avatar.freya.hpNow <= 0)
		{
			Debug.Log("Game Over");

		}
		if(Avatar.monsterList[Methods.monsterIndex].hpNow <= 0)
		{
			Methods.monsterIndex ++;
			enemy.gameObject.SetActive(false);
			obj.gameObject.SetActive(true);
		}
	}

	public static void DistanceNormalize()
	{
		if(Combat.distance < 0)
		{
			Combat.distance = 0;
		}
	}
	public static void DistanceUpdate()
	{
		Combat.distance += Combat.comboList[lastComboIndex].move;
	}
	public static void ConfirmCombo()
	{	
		if(comboIsReady == true)
		{
			DistanceUpdate();
			DistanceNormalize();
			Monster.HPUpdate();
			Monster.RageUpdate();
			Freya.HPUpdate();
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
		comboIsReady = false;
		checkerLock = false;
		result = false;
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
		ComboLineToString();
		if(comboForCheck != null)
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
					if(result == false)
					{
						result = false;
						checkerLock = false;
					}
					index ++;
					
				}
			}
		}

		ResultChecker();

		index = 0;
		Debug.Log("result: " + result);
	}
	public static void ResultChecker()
	{
		if(result == false)
		{
			comboIsReady = false;
			checkerLock = false;
			result = false;
		}
		if(result == true)
		{
			comboIsReady = true;
		}
	}
	public static void ActionsLoad()
	{
		Actions action01 = new Actions("ActionName1", 1, 1);
		Actions action02 = new Actions("ActionName2", 2, 2);
		Actions action03 = new Actions("ActionName3", 3, 3);
		Actions action04 = new Actions("ActionName4", 4, 4);

		Combat.actionList.Add(action01);
		Combat.actionList.Add(action02);
		Combat.actionList.Add(action03);
		Combat.actionList.Add(action04);

	}
	public static void CombosLoad()
	{
	//(string newName, string newCode, int newCrit, int newMove, int newRage, int newDodge, int newAtk)

		Combos deepBreath = new Combos("Deep Breath", "111", 3, 0, 2, 6, 0);
		Combos rollout = new Combos("Rollout", "121", 2, 1, 1, 4, 0);
		Combos upperCut = new Combos("Jab", "123", 2, -1, 1, 0, 4);
		Combos flyingKick = new Combos("Flying Kick", "224", 4, -2, 3, 0, 11);

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
			ClearComboLine();
		}
	}

}
