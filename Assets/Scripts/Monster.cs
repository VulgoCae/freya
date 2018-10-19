using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster {

	public string name;
	public int hpNow,hpMax;
	public Monster(string newName, int newHP)
	{
		name = newName;
		hpNow = newHP;
		hpMax = newHP;
	}
}
