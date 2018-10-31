using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freya {

	public int hpNow, hpMax, dodge;

	public static void HPUpdate()
	{
		if(Monster.actionReady == true)
		{
			//falta dodge
			Avatar.freya.hpNow -= Avatar.monsterList[Methods.monsterIndex].atk;			
			Monster.actionReady = false;
		}
		if(Monster.rageTrigger == true)
		{
			Monster.LoadAction();
		}
	}


	public Freya(int newHP, int newDodge)
	{
		hpMax = newHP;
		hpNow = newHP;
		dodge = newDodge;
	}
}
