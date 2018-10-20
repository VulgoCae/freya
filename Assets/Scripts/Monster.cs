using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster {

	public string name;
	public int hpNow, hpMax, shield, trigger, attack, power;
	
	public Monster(string newName, int newHP, int newShield, int newTrigger, int newAttack, int newPower)
	{
		name = newName;
		hpNow = newHP;
		hpMax = newHP;
		shield = newShield;
		trigger = newTrigger;
		attack = newAttack;
		power = newPower;
	}
}
