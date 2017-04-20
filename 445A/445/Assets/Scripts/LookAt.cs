using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {

	private Transform cameraTransform;
	private Transform cameraDesiredLookAt;

	private const float CTS = 3.0f;

	private void Start()
	{
		cameraTransform = Camera.main.transform;
	}

	private void Update()
	{
		if (cameraDesiredLookAt != null)
		{
			cameraTransform.rotation = Quaternion.Slerp (cameraTransform.rotation, cameraDesiredLookAt.rotation, CTS * Time.deltaTime);
		}
	}


	//public void LookAtMenu(Transform menuTransform)
	//{
	//	cameraDesiredLookAt = menuTransform;
	//}

	public void LookAtMenu(Transform menuTransform)
	{
		Camera.main.transform.LookAt (menuTransform.position);
	} 

}
