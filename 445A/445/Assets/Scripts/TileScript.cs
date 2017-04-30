using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour {

	private float fallDown = 1.5f;

	void OnTriggerExit(Collider other) {

		if(other.tag == "Player") {
			
			TileManager.Instance.SpawnTile();

			StartCoroutine (FallDown ());

		}
	}

	IEnumerator FallDown()
	{  
		
		yield return new WaitForSeconds(fallDown);
		GetComponent<Rigidbody>().isKinematic = false;
		yield return new WaitForSeconds (1);

		switch (gameObject.name) {

		case "RightTile":
			TileManager.Instance.RightTiles.Push (gameObject);
			gameObject.GetComponent<Rigidbody> ().isKinematic = true;
			gameObject.SetActive (false);
			break;

		case "BottomTile":
			TileManager.Instance.BottomTiles.Push (gameObject);
			gameObject.GetComponent<Rigidbody> ().isKinematic = true;
			gameObject.SetActive (false);
			break;

		case "LeftTile":
			TileManager.Instance.LeftTiles.Push (gameObject);
			gameObject.GetComponent<Rigidbody> ().isKinematic = true;
			gameObject.SetActive (false);
			break;
		}
	}
}
