using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inputs : MonoBehaviour {

	public Text comboLineText;
	public Text comboCheckerText;
	public int i = 0;
	
	public void ComboCheckerWriter()
	{
		if(Methods.comboIsReady == true)
		{
			comboCheckerText.text = "Combo " + Combat.comboList[Methods.lastComboIndex].name + " is ready!";
			Methods.comboIsReady = false;
		}
		if(Methods.comboIsReady == false)
		{
			comboCheckerText.text = "";
		}
	}

	public void ClearComboLineText()
	{
		comboLineText.text = "";
	}

	public void ComboLineWriter()
	{
		ClearComboLineText();
		foreach(int i in Combat.comboLine)
		{	
			comboLineText.text += i.ToString();
		}

	}

	public void ConfirmLine()
	{
		ComboLineWriter();
		Methods.ComboLineToString();
		Methods.ComboChecker();
		Methods.ResultChecker();
		Methods.ConfirmCombo();
		ComboLineWriter();
		
	}

	public void AddActionToLine(int index)
	{
		Methods.ComboLineLength();
		Combat.comboLine.Add(Combat.actions[index]);
		ComboLineWriter();
		Methods.ComboLineToString();
		Methods.ComboChecker();
		Methods.ResultChecker();
		ComboCheckerWriter();
	}

	void Start () {
		
	}
	
	void Update () {
		
	}
}
