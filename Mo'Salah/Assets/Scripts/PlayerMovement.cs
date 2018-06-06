using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class PlayerMovement : MonoBehaviour {

	// This is a reference to the Rigidbody component called "rb"
	public Rigidbody rb;

	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;
	public GameManager manager;
	public int counter = 0;
	public float timeLeft;
	public float restartDelay = 0.5f;

	public KeyCode keyLeft;
	public KeyCode keyRight;
	public KeyCode keyUp;
	public KeyCode keyDown;


	public PlayerMovement otherPlayer;

	public Text playerText;

	// We marked this as "Fixed"Update because we 
	// are using it to mess with physics.
	void FixedUpdate ()
	{
		// Add a forward force
		rb.AddForce (0, 0, forwardForce * Time.deltaTime);

		// Add a force to the right
		// If the player is pressing the "D" key
		if (Input.GetKey (keyRight)) {
			rb.AddForce (sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		// Add a force to the left
		// If the player is pressing the "A" key
		if (Input.GetKey (keyLeft)) {
			rb.AddForce (-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey (keyUp)) 
		{
			DoPowerUp (counter);
			playerText.text = "";
			counter = 0;
		}

		if (Input.GetKey (keyDown)) 
		{
			otherPlayer.DoPowerUp (counter);
			playerText.text = "";
			counter = 0;
		}
	}


	public void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "PowerUp" && counter == 0) {
			counter = Random.Range (1, 3);
			playerText.text = "Powerup";
		}

		else if (other.gameObject.tag == "Respawn") {
			transform.position = new Vector3 (5f, 5f, 0f);
		}

		else if (other.gameObject.tag == "Respawn2") {
			transform.position = new Vector3 (0f, -20f, 1290f);
		}

		else if (other.gameObject.tag == "Finish") {
			//Time.timeScale = 0;
			Win ();
			otherPlayer.Lose ();
			//AudioListener.volume = 0;
			Invoke("Credit", restartDelay);
		}
	}

	void Update ()
		{
			if (rb.position.y < -1f) 
			{
				manager.EndGame ();

			}
		}


	public void DoPowerUp(int counter)
	{
		if (counter == 1) {
			transform.localScale += new Vector3 (Random.Range(-0.6f, 0.6f), Random.Range(-0.1f, 0.9f), Random.Range(-0.6f, 0.6f));

		}

		if (counter == 2) {

			rb.AddForce (0, 0, forwardForce * Time.deltaTime * Random.Range(-200f, 200f));

		}
	}

	public void Win()
	{
		playerText.text = "You Win!";
		playerText.color = Color.green;
	}

	public void Credit()
	{
		SceneManager.LoadScene ("Credits");
	}

	public void Lose()
	{
		playerText.text = "You Lose!";
		playerText.color = Color.red;
	}
}

