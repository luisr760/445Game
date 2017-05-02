using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour {


	GameObject player;
	public int score;

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
			GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerScript> ().SCORE += score;
			SoundManagerScript.PlaySound("eat");

			Destroy (gameObject);
		}
	}
}
