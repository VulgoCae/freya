using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster {

	public string name;

	public int hpNow, hpMax, shield, rageNow, rageMax, attack, rank;

	public Monster(string newName, int newHP, int newShield, int newRage, int newAttack, int newRank)
	{
		name = newName;
		hpNow = newHP;
		hpMax = newHP;
		shield = newShield;
		rageMax = newRage;
		rageNow = 0;
		attack = newAttack;
		rank = newRank;
	}
}
