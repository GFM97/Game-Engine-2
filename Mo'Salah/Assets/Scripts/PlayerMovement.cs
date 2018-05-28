﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// This is a reference to the Rigidbody component called "rb"
	public Rigidbody rb;

	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;
	public float timeLeft;
	public GameManager manager;
	public int counter = 0;

	public KeyCode keyLeft;
	public KeyCode keyRight;
	public KeyCode keyUp;
	public KeyCode keyDown;

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
			if (counter == 1) {
				transform.localScale += new Vector3 (Random.Range(-0.9f, 0.9f), Random.Range(-0.9f, 0.9f), Random.Range(-0.9f, 0.9f));
				counter = 0;
			}

			if (counter == 2) {

				rb.AddForce (0, 0, forwardForce * Time.deltaTime * Random.Range(-200f, 200f));
				counter = 0;
			}
		}

		if (Input.GetKey (keyDown)) 
		{
			if (counter == 1) {
				transform.localScale += new Vector3 (Random.Range(-0.9f, 0.9f), Random.Range(-0.9f, 0.9f), Random.Range(-0.9f, 0.9f));
				counter = 0;
			}

			if (counter == 2) {

				rb.AddForce (0, 0, forwardForce * Time.deltaTime * Random.Range(-200f, 200f));
				counter = 0;
			}
		}
	}


	public void OnTriggerEnter (Collider other)
	{
		if(other.gameObject.tag == "PowerUp" && counter == 0)
		{

			counter = Random.Range(1, 3);
		}
	}

	void Update ()
	{
		if (rb.position.y < -1f) 
		{
			manager.EndGame ();

		}
	}
}
	
