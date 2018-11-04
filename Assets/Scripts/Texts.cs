using UnityEngine;
using UnityEngine.UI;

public class Texts : MonoBehaviour {

	public Text freyaHP;
	public Text freyaDodge;

	public Text monsterHPRange;
	public Text monsterDodge;

	public Text distanceText;

	void Start () {
		
	}
	
	void Update () {
		distanceText.text = Combat.distance.ToString();
		freyaHP.text = Avatar.freya.hpNow + "/" + Avatar.freya.hpMax;
		freyaDodge.text =  Avatar.freya.dodge.ToString();
		monsterHPRange.text = Avatar.monsterList[Methods.monsterIndex].hpNow + "/" + Avatar.monsterList[Methods.monsterIndex].hpMax +
		"\n" + Avatar.monsterList[Methods.monsterIndex].rageNow + "/" + Avatar.monsterList[Methods.monsterIndex].rageMax;
		monsterDodge.text =  Avatar.monsterList[Methods.monsterIndex].dodge.ToString()
		+"\n" + Avatar.monsterList[Methods.monsterIndex].atk.ToString();
	}
}
