using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;

	public float restartDelay = 0.5f;

	public GameObject completeLevelUI;

	public void CompleteLevel()
	{
		completeLevelUI.SetActive(true);
	}

	public void EndGame ()
	{
		if (gameHasEnded == false)
		{
			gameHasEnded = true;
			//Invoke("Restart", restartDelay);
		}

	}

	public void Update()
	{
		if(PlayerPrefs.GetInt("Muted") == 1)
		{
			AudioListener.pause = true;
		}

		if(PlayerPrefs.GetInt("Muted") == 0)
		{
			AudioListener.pause = false;
		}
	}

//	void Restart()
//	{
//		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
//	}


}


