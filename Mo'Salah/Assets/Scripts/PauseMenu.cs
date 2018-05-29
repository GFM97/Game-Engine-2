using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public bool isPaused;

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
			AudioListener.volume = 0.2f;
		}
		else
		{
			canvas.SetActive(false);
			Time.timeScale = 1f;
			AudioListener.volume = 1f;
		}
	}
}