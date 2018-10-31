using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combos {

	public string name, code;
	
	public int crit, move, rage, dodge, atk;
	
	public Combos(string newName, string newCode, int newCrit, int newMove, int newRage, int newDodge, int newAtk)
	{
		name = newName;
		code = newCode;
		crit = newCrit;
		move = newMove;
		rage = newRage;
		dodge = newDodge;
		atk = newAtk;
	}

}
