using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	bool isMuted;
	public bool isPaused;

	public GameObject canvas;

	// Update is called once per frame
	void Update ()
	{
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

		if (Input.GetKeyDown(KeyCode.Escape))
		{
			isPaused = !isPaused;
		}

		AudioListener.volume = 1f;
		if(PlayerPrefs.GetInt("Muted") == 1)
		{
			isMuted = true;
		}
	}

	public void Resume()
	{
		isPaused = false;
	}

	public void MuteSound()
	{
		isMuted = !isMuted;
		if(isMuted == true)
		{
			PlayerPrefs.SetInt("Muted", 1);
		}
		else
		{
			PlayerPrefs.SetInt("Muted", 0);
		}
	}

	public void MainMenu()
	{
		SceneManager.LoadScene(0);
	}
}