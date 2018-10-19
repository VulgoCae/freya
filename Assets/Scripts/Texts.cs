using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texts : MonoBehaviour {

	public Text freyaTxts;
	public Text monsterTxts;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		freyaTxts.text = Avatar.freya.hpNow + "/" + Avatar.freya.hpMax;
		monsterTxts.text = Avatar.hound.hpNow + "/" + Avatar.hound.hpMax;
		
	}
}
