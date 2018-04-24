using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu: MonoBehaviour
{

	bool isMuted;
	public GameObject ls;
	public GameManager gm;

	public void Start()
	{
		AudioListener.volume = 1f;
		if(PlayerPrefs.GetInt("Muted") == 1)
		{
			isMuted = true;
		}
	}

	public void StartGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void Quit()
	{
		Debug.Log("Quit");
		Application.Quit();
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

	public void LoadLevel(int level)
	{
		SceneManager.LoadScene(level);
	}

	public void OpenLevelSelect()
	{
		ls.SetActive(true);
	}

	public void Back()
	{
		ls.SetActive(false);
	}
}
