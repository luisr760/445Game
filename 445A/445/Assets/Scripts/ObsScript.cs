using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsScript : MonoBehaviour {

	GameObject player;

	void Update()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		if (transform.position.z > 0)
		{
			if (transform.position.z < player.transform.position.z) {
				Destroy (gameObject, 2);
			}
		}
		else
		{
			if (transform.position.z > player.transform.position.z) {
				Destroy (gameObject, 2);
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerScript> ().speed += 20f;
			Destroy (gameObject);
		}
	}
}
