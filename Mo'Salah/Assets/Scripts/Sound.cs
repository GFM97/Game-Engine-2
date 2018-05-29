using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour {
	public AudioSource audio;

	public void ChangeVol(float newValue) {
		float newVol = audio.volume;
		newVol = newValue;
		audio.volume = newVol;
	}
}
