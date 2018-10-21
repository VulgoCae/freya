using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour {

	public static Freya freya = new Freya(30, 3);
	
	public static Monster hound = new Monster("Hound", 15, 1, 1, 1, 1);
	
	void Start () {

		Methods.DebugLogs();
		Methods.CombosLoad();
	
	}
	
	void Update () {
		
	}
}
