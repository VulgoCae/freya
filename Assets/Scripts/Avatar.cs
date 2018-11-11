using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour {
//	public Monster(string newName, int newHP, int newDodge, int newRage, int newAtk, int newRank)

	public static Freya freya = new Freya(50, 0, 0);
	public static Monster hound = new Monster("Hound", 55, 0, 4, 6, 1);
	public static Monster creeper = new Monster("Creeper", 60, 10, 3, 13, 1);
	public static Monster winterSoldier = new Monster("Winter Soldier", 80, 16, 3, 16, 2);
	public static Monster lordDraugr = new Monster("Lord Draugr", 120, 20, 3, 20, 3);
	public static List<Monster> monsterList = new List<Monster>();
	
	public static void LoadMonsters()
	{
		monsterList.Add(hound);
		monsterList.Add(creeper);
		monsterList.Add(winterSoldier);
		monsterList.Add(lordDraugr);
	}


	void Start () {


	}
	
	void Update () {
		
	}
}
