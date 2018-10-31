using UnityEngine;
using UnityEngine.UI;

public class Texts : MonoBehaviour {

	public Text freyaTexts;

	public Text monsterTexts;

	public Text distanceText;

	void Start () {
		
	}
	
	void Update () {
		distanceText.text = Combat.distance.ToString();
		freyaTexts.text = Avatar.freya.hpNow + "/" + Avatar.freya.hpMax + "\n" + Avatar.freya.dodge;
		monsterTexts.text = Avatar.hound.hpNow + "/" + Avatar.hound.hpMax + "\n" + Avatar.hound.dodge
							+ "\nRage: " + Avatar.hound.rageNow + "/" + Avatar.hound.rageMax
							+ "\nRank: " + Avatar.hound.rank;
		
	}
}
