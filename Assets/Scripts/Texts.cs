using UnityEngine;
using UnityEngine.UI;

public class Texts : MonoBehaviour {

	public Text freyaTexts;

	public Text monsterTexts;

	void Start () {
		
	}
	
	void Update () {
		
		freyaTexts.text = Avatar.freya.hpNow + "/" + Avatar.freya.hpMax + "\n" + Avatar.freya.shield;
		monsterTexts.text = Avatar.hound.hpNow + "/" + Avatar.hound.hpMax + "\n" + Avatar.hound.shield;
		
	}
}
