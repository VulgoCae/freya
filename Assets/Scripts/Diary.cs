using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diary : MonoBehaviour {

	public GameObject HoundDraw;
	public GameObject CreeperDraw;
	public GameObject WinterSoldierDraw;
	public GameObject LadyDraugrDraw;

	public List<GameObject> creatureDraws = new List<GameObject>();
	public void Selected(int i)
	{
			creatureDraws[i].gameObject.SetActive(true);

	}
	public void Unselected(int i)
	{
			creatureDraws[i].gameObject.SetActive(false);

	}

	void Start () {

		creatureDraws.Add(HoundDraw);
		creatureDraws.Add(CreeperDraw);
		creatureDraws.Add(WinterSoldierDraw);
		creatureDraws.Add(LadyDraugrDraw);
		
	}
	
	void Update () {
		
	}
}
