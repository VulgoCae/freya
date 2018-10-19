using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
	void Start () {
		Debug.Log("Freya HP: " + Avatar.freya.hpMax );
		Debug.Log("Hound HP: " + Avatar.hound.hpMax );
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
