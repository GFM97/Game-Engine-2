using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu: MonoBehaviour
{
	
	public GameManager gm;

	public void Start()
	{
		AudioListener.volume = 1f;
	}

	public void StartGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	void Update()
	{
		if (Input.GetKey(KeyCode.Space)) 
		{
			SceneManager.LoadScene ("Start");
		}
	}

	public void Quit()
	{
		Debug.Log("Quit");
		Application.Quit();
	}
}

