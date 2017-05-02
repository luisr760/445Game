using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	GameObject player;

	void Start()
	{

	}
	void Update(){
		player = GameObject.FindGameObjectWithTag ("Player");
		if (transform.position.z > 0) {
			if (transform.position.z < player.transform.position.z + 15) {
				Destroy (gameObject, 2);
			}
		} else {
			if (transform.position.z > player.transform.position.z) {
				Destroy (gameObject, 2);
			}
		}
	}
	void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.tag == "Player") {
			PlayerScript ps = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerScript>();
			ps.death();
			ps.IsDead = true;
			ps.GameOver ();
			ps.resetButton.SetActive (true);
			if (ps.transform.childCount > 2) {
				ps.transform.GetChild (2).transform.parent = null;
			}
			Instantiate (ps.particles, ps.transform.position, Quaternion.identity);
			ps.DestroyPlayer ();
		}
	}
}
