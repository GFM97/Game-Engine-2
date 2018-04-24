using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

	// A reference to PlayerMovement script
	public PlayerMovement movement;

	// This function runs when we hit another object.
	// We get information about the collision and call it "colisionInfo".
	//void OnCollisionEnter (Collision collisionInfo)
	//{
		// We check if the object we collided with has a tag called "Obstacle".
		//if (collisionInfo.collider.tag == "Obstacle")
		//{
			// Disable the players movement.
			//movement.enabled = false;
			//GetComponent<AudioSource>().Play();
			//FindObjectOfType<GameManager>().EndGame();
		//}
	//}
}
