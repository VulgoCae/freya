using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freya {

	public int hpNow, hpMax, shield;

	public static void HPUpdate()
	{
		Avatar.freya.hpNow += Combat.comboList[Methods.lastComboIndex].atk;
	}


	public Freya(int newHP, int newShield)
	{
		hpMax = newHP;
		hpNow = newHP;
		shield = newShield;
	}
}
