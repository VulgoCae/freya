using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freya {

	public int hpNow, hpMax, dodge, progress;

	public static void DodgeUpdate()
	{
		if(Combat.actionList[Methods.lastComboIndex].dodge > 0)
		{
			Avatar.freya.dodge += Combat.actionList[Methods.lastComboIndex].dodge;
		}
	}
	public static void HPUpdate()
	{
		DodgeUpdate();

		if(Monster.actionReady == true)
		{
			Monster.LoadAction();
			if(Avatar.freya.dodge > Avatar.monsterList[Methods.monsterIndex].atk)
			{
				Avatar.freya.dodge -= Avatar.monsterList[Methods.monsterIndex].atk;
			}
			if(Avatar.freya.dodge <= Avatar.monsterList[Methods.monsterIndex].atk)
			{
				Avatar.freya.hpNow -= (Avatar.monsterList[Methods.monsterIndex].atk - 
									   Avatar.freya.dodge);
				Avatar.freya.dodge = 0;
			}
			Monster.actionReady = false;
		}
	}

	public Freya(int newHP, int newDodge, int newProgress)
	{
		hpMax = newHP;
		hpNow = newHP;
		dodge = newDodge;
		progress = newProgress;
	}
}
