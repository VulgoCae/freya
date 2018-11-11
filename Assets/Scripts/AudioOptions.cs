using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioOptions : MonoBehaviour {

	public void MusicOption(AudioSource m)
	{
		
		if(m.isPlaying == true)
		{
			m.Stop();
		}
		else m.Play();
	}

	public void QuitGame()
	{
		if(Avatar.freya.hpNow > 0)
		{
			PlayerPrefsUtility.SetEncryptedInt("freyaHPNow", Avatar.freya.hpNow);
			PlayerPrefsUtility.SetEncryptedInt("monsterIndex", Methods.monsterIndex);
			PlayerPrefsUtility.SetEncryptedInt("monsterHPNow", Avatar.monsterList[Methods.monsterIndex].hpNow);
			MainMenu.hasSavedGame = 1;
			PlayerPrefsUtility.SetEncryptedInt("hasSavedGamex", MainMenu.hasSavedGame);
			Debug.Log(PlayerPrefsUtility.GetEncryptedInt("freyaHPNow"));

		}
		Application.Quit();

	}

}
