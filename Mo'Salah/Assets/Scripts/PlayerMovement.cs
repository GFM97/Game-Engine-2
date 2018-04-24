using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// This is a reference to the Rigidbody component called "rb"
	public Rigidbody rb;

	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;
	public float upwardForce = 200f;
	public GameManager manager;

	public KeyCode keyLeft;
	public KeyCode keyRight;
	public KeyCode keyUp;

	// We marked this as "Fixed"Update because we 
	// are using it to mess with physics.
	void FixedUpdate ()
	{
		// Add a forward force
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);

		// Add a force to the right
		// If the player is pressing the "D" key
		if(Input.GetKey(keyRight))
		{
			rb.AddForce (sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		// Add a force to the left
		// If the player is pressing the "A" key
		if(Input.GetKey(keyLeft))
		{
			rb.AddForce (-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if(Input.GetKey(keyUp))
		{
			rb.AddForce (0,upwardForce * Time.deltaTime, 0, ForceMode.VelocityChange);
		}
	}

	void Update ()
	{
		if (rb.position.y < -1f) {
			manager.EndGame ();

		}
	}
}
