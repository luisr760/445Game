using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour {
	private float speed = .5f;

	
	// Update is called once per frame
	void Update () 
	{
		
		float temp = Input.acceleration.x;
		transform.Translate (-temp * speed, 0, 0);
	}
}
