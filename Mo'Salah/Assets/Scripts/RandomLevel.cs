using UnityEngine;
using System.Collections;

public class RandomLevel : MonoBehaviour {

	public GameObject Obstacle;
	public int min, max;

	float seconds = 1f;
	float minSeconds = 0.3f;

	void Start()
	{
		StartCoroutine (Spawn ());
	}

	IEnumerator Spawn()
	{
		while (true) {
			yield return new WaitForSeconds (seconds);

			// spawn
			Instantiate (Obstacle, GeneratedPosition (), Quaternion.identity);

			seconds -= 0.025f;
			if (seconds < minSeconds)
				seconds = minSeconds;
		}
	}

	Vector3 GeneratedPosition()
	{
		Vector3 pos = transform.position;
		pos.x = Random.Range(min,max);
		pos.z += 30f;

		return pos;
	}
}
