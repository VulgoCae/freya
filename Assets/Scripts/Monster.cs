using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster {

	public static int actionIndex;
	public static bool rageTrigger;
	public static bool actionReady;
	public string name;
	public int hpNow, hpMax, dodge, rageNow, rageMax, atk, rank;

	public static void LoadAction()
	{
		if(rageTrigger == true)
		{
			Avatar.monsterList[Methods.monsterIndex].atk +=
			Combat.actionList[actionIndex].atk;
			Avatar.monsterList[Methods.monsterIndex].dodge +=
			Combat.actionList[actionIndex].dodge;
			if(Avatar.monsterList[Methods.monsterIndex].rageNow >= 
			   Avatar.monsterList[Methods.monsterIndex].rageMax)
			{
				Avatar.monsterList[Methods.monsterIndex].rageNow = 0;
			}
		}
	}

	public static void RageUpdate()
	{
		Avatar.monsterList[Methods.monsterIndex].rageNow += 
		Combat.comboList[Methods.lastComboIndex].rage;
	
		if( Avatar.monsterList[Methods.monsterIndex].rageNow >=
			Avatar.monsterList[Methods.monsterIndex].rageMax)
			{
				
				rageTrigger = true;
				actionReady = true;
			}
		Debug.Log("rage trigger: " + rageTrigger);
	}

	public static void HPUpdate()
	{
		if(Combat.comboList[Methods.lastComboIndex].atk != 0)
		{
			Avatar.monsterList[Methods.monsterIndex].hpNow -=
			(Combat.comboList[Methods.lastComboIndex].atk - Avatar.monsterList[Methods.monsterIndex].dodge);
			DodgeUpdate();
		}
	}

	public static void DodgeUpdate()
	{
		Avatar.monsterList[Methods.monsterIndex].dodge -= Combat.comboList[Methods.lastComboIndex].atk;
		if(Avatar.monsterList[Methods.monsterIndex].dodge < 0)
		{
			Avatar.monsterList[Methods.monsterIndex].dodge = 0;
		}
	}

	public Monster(string newName, int newHP, int newDodge, int newRage, int newAtk, int newRank)
	{
		name = newName;
		hpNow = newHP;
		hpMax = newHP;
		dodge = newDodge;
		rageMax = newRage;
		rageNow = 0;
		atk = newAtk;
		rank = newRank;
	}
}
