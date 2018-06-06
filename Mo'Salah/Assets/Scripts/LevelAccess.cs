using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelAccess : MonoBehaviour {

	public int level;
	public GameObject image;

	void Awake()
	{
		// PlayerPrefs.SetInt ("level", 0);
		bool active = PlayerPrefs.GetInt ("level") > level || level == 1;
		image.SetActive (!active);
		GetComponent<Button> ().interactable = active;
	}
}