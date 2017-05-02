﻿using System.Collections;
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
				Destroy (gameObject, 5);
			}
		}
		else
		{
			if (transform.position.z > player.transform.position.z) {
				Destroy (gameObject, 5);
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerScript> ().speed = 25f;
			SoundManagerScript.PlaySound("hit");
			Destroy (gameObject);
			StartCoroutine (Example());
		}
	}
	IEnumerator Example()
	{
		yield return new WaitForSecondsRealtime(1);
		GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerScript> ().speed = 8f;
	}
}
