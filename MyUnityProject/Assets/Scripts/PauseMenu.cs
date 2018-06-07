using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	bool isPaused;

	public GameObject canvas;

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown("Cancel"))
		{
			Pause ();
		}
	}

	public void Resume()
	{
		isPaused = false;
		canvas.SetActive(isPaused);
		Time.timeScale = 1;
	}

	public void MainMenu()
	{
		SceneManager.LoadScene(0);
	}

	void Pause() {
		isPaused = !isPaused;

		if (isPaused)
		{
			canvas.SetActive(true);
			Time.timeScale = 0f;
		}
		else
		{
			canvas.SetActive(false);
			Time.timeScale = 1f;
		}
	}
}