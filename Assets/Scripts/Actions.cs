using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actions {

	public string name;

	public int atk, dodge;  

	public Actions(string newName, int newAtk, int newDodge)
	{
		name = newName;
		atk = newAtk;
		dodge = newDodge;
	}

}
