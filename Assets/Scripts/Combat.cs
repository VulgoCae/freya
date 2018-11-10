using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour {

	public static List<int> actions = new List<int>();
	public static List<int> comboLine = new List<int>();
	public static List<string> comboListCode = new List<string>();
	public static List<Combos> comboList = new List<Combos>();
	public static List<Actions> actionList = new List<Actions>();
	public List<GameObject> creatureListObj = new List<GameObject>();

	public GameObject hound;
	public GameObject creeper;
	public GameObject winterSoldier;
	public GameObject ladyDraugr;

	public static int distance = 5;

	void Awake()
	{
		Debug.Log("monster index: " + Methods.monsterIndex);
		creatureListObj.Add(hound);
		creatureListObj.Add(creeper);
		creatureListObj.Add(winterSoldier);
		creatureListObj.Add(ladyDraugr);
	}

	void Start () {
		Debug.Log(Methods.monsterIndex);
		//Methods.monsterIndex = Avatar.freya.progress;
		creatureListObj[Methods.monsterIndex].gameObject.SetActive(true);

	}

}
