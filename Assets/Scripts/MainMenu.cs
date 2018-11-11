using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour {

	public static int hasSavedGame;
	public void StartGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	
	public void QuitGame()
	{
		if(Avatar.freya.hpNow > 0)
		{
			PlayerPrefsUtility.SetEncryptedInt("freyaHPNow", Avatar.freya.hpNow);
			PlayerPrefsUtility.SetEncryptedInt("monsterIndex", Methods.monsterIndex);
			PlayerPrefsUtility.SetEncryptedInt("monsterHPNow", Avatar.monsterList[Methods.monsterIndex].hpNow);
			hasSavedGame = 1;
			PlayerPrefsUtility.SetEncryptedInt("hasSavedGamex", hasSavedGame);
			Debug.Log(PlayerPrefsUtility.GetEncryptedInt("freyaHPNow"));
		}
		Application.Quit();
	}
	public void ContinueGame()
	{
		if(hasSavedGame == 1)
		{
			Avatar.freya.hpNow = PlayerPrefsUtility.GetEncryptedInt("freyaHPNow");
			Methods.monsterIndex = PlayerPrefsUtility.GetEncryptedInt("monsterIndex");
			Avatar.monsterList[Methods.monsterIndex].hpNow = PlayerPrefsUtility.GetEncryptedInt("monsterHPNow");
			StartGame();

		}
		StartGame();

	}

	public void ContinueReward()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}

	public void LoadMainMenu()
	{
		// Game Over
		SceneManager.LoadScene(0);
		Avatar.freya.hpNow = Avatar.freya.hpMax;
		foreach(Monster m in Avatar.monsterList)
		{
			m.hpNow = m.hpMax;
		}
		Methods.monsterIndex = 0;
		Avatar.freya.progress = 0;
		hasSavedGame = 0;
	}

	void Awake()
	{	Methods.DebugLogs();
		Methods.CombosLoad();
		Methods.ActionsLoad();
		Avatar.LoadMonsters();

		hasSavedGame = PlayerPrefsUtility.GetEncryptedInt("hasSavedGamex");		
	}
}
