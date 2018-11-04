using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freya {

	public int hpNow, hpMax, dodge;

	public static void HPUpdate()
	{
		Debug.Log("action ready: " + Monster.actionReady);
		if(Monster.actionReady == true)
		{
			Monster.LoadAction();
			Avatar.freya.hpNow -= (Avatar.monsterList[Methods.monsterIndex].atk -
								   Avatar.freya.dodge);
			if(Avatar.freya.dodge <= Avatar.monsterList[Methods.monsterIndex].atk)
			{
				Avatar.freya.dodge = 0;
			}			
			Monster.actionReady = false;
			
		}
	}

	public Freya(int newHP, int newDodge)
	{
		hpMax = newHP;
		hpNow = newHP;
		dodge = newDodge;
	}
}
