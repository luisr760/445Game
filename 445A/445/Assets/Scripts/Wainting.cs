using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wainting : MonoBehaviour {


		void Start()
		{
			StartCoroutine(Example());
		}

		IEnumerator Example()
		{
			yield return new WaitForSecondsRealtime(2);
		}

}
