using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Methods {

	public static void CombosLoad()
	{
		Combos deepBreath = new Combos("Deep Breath", 111, 3);
		Combos rollout = new Combos("Rollout", 121, 2);
		Combos upperCut = new Combos("Uppercut", 123, 0);
		Combos flyingKick = new Combos("Flying Kick", 224, 2);
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
