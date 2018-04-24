using UnityEngine;

public class EndTrigger : MonoBehaviour {

	public GameManager gameManager;
	public int level;

	void OnTriggerEnter()
	{
		gameManager.CompleteLevel ();

		if (PlayerPrefs.GetInt ("level") < level) {
			PlayerPrefs.SetInt ("level", level);
		}
	}
}
