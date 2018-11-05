using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cards : MonoBehaviour {
	public GameObject DeepBreath;
	public GameObject Rollout;
	public GameObject FlyingKick;
	public GameObject Uppercut;

	public static List<GameObject> cardsList = new List<GameObject>();

	public void OnClick(GameObject gameObj)
	{
		//Debug.Log("comboisready: " + Methods.comboIsReady);
		//Debug.Log("lastcomboindex: " + Methods.lastComboIndex);
		if(Methods.comboIsReady == true)
		{
			cardsList[Methods.lastComboIndex].gameObject.SetActive(true);
		}
		else cardsList[Methods.lastComboIndex].gameObject.SetActive(false);
	}
	
	void Start () {
		cardsList.Add(DeepBreath);
		cardsList.Add(Rollout);
		cardsList.Add(FlyingKick);
		cardsList.Add(Uppercut);
	}
	
	void Update () {
		
	}
}
