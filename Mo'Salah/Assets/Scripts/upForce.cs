using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upForce : MonoBehaviour {

	public Rigidbody rb;

	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			rb.AddForce (0, Time.deltaTime * 5000f, 0);
		}
	}
}
