using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour {

	public static Freya freya = new Freya(50, 0, 0);
	public static Monster hound = new Monster("Hound", 1, 6, 6, 1, 1);
	public static Monster creeper = new Monster("Creeper", 15, 1, 1, 1, 1);
	public static Monster winterSoldier = new Monster("Winter Soldier", 15, 1, 1, 1, 1);
	public static Monster lordDraugr = new Monster("Lord Draugr", 15, 1, 1, 1, 1);
	public static List<Monster> monsterList = new List<Monster>();
	
	public static void LoadMonsters()
	{
		monsterList.Add(hound);
		monsterList.Add(creeper);
		monsterList.Add(winterSoldier);
		monsterList.Add(lordDraugr);
	}


	void Start () {

		Methods.DebugLogs();
		Methods.CombosLoad();
		Methods.ActionsLoad();
		LoadMonsters();
	}
	
	void Update () {
		
	}
}
