using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inputs : MonoBehaviour {
	public Text comboLineText;
	
	public void ComboLineWriter()
	{
		
		comboLineText.text = "";
		foreach(int i in Combat.comboLine)
		{
			comboLineText.text += i.ToString();
		}
	}
	public void AddActionToLine(int index)
	{
		Methods.ComboLineLength();
		Combat.comboLine.Add(Combat.actions[index]);
		ComboLineWriter();
		Debug.Log(index);

	}

	void Start () {
		
	}
	
	void Update () {
		
	}
}
