using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diary : MonoBehaviour {

	public GameObject houndDraw;
	public GameObject creeperDraw;
	public GameObject winterSoldierDraw;
	public GameObject ladyDraugrDraw;

	public GameObject diaryCombo01;
	public GameObject diaryCombo02;
	public GameObject diaryCombo03;
	public GameObject diaryCombo04;

	public GameObject combosLabel;
	public GameObject monstersLabel;
	public int indexCard;
	public List<GameObject> creatureDraws = new List<GameObject>();
	public List<GameObject> diaryCombos = new List<GameObject>();

	public void SelectMonstersLabel()
	{
		combosLabel.gameObject.SetActive(false);
		monstersLabel.gameObject.SetActive(true);
	}
	
	public void SelectCombosLabel()
	{
		combosLabel.gameObject.SetActive(true);
		monstersLabel.gameObject.SetActive(false);
	}
	public void SetCardDiaryMax()
	{	
		diaryCombos[0].gameObject.SetActive(false);
		diaryCombos[1].gameObject.SetActive(false);
		diaryCombos[2].gameObject.SetActive(false);
		diaryCombos[3].gameObject.SetActive(false);

		diaryCombos[indexCard].gameObject.SetActive(true);
		if(indexCard < 3)
		{
			indexCard++;
		}
	}
	public void SetCardDiaryMin()
	{	
		diaryCombos[0].gameObject.SetActive(false);
		diaryCombos[1].gameObject.SetActive(false);
		diaryCombos[2].gameObject.SetActive(false);
		diaryCombos[3].gameObject.SetActive(false);

		diaryCombos[indexCard].gameObject.SetActive(true);
		if(indexCard > 0)
		{
			indexCard--;
		}
	}
	public void Selected(int i)
	{
			creatureDraws[i].gameObject.SetActive(true);

	}
	public void Unselected(int i)
	{
			creatureDraws[i].gameObject.SetActive(false);

	}

	void Start () {

		creatureDraws.Add(houndDraw);
		creatureDraws.Add(creeperDraw);
		creatureDraws.Add(winterSoldierDraw);
		creatureDraws.Add(ladyDraugrDraw);

		diaryCombos.Add(diaryCombo01);
		diaryCombos.Add(diaryCombo02);
		diaryCombos.Add(diaryCombo03);
		diaryCombos.Add(diaryCombo04);
		
	}
	
	void Update () {
		
	}
}
