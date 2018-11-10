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
}
