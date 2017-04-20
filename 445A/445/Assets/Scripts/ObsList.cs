using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsList : MonoBehaviour {

	private List<GameObject> obsList;
	public GameObject obs1;
	public GameObject obs2;
	public GameObject obs3;

	void Awake()
	{
		obsList = new List<GameObject> ();
		obsList.Add (obs1);
		obsList.Add (obs2);
		obsList.Add (obs3);
	}
	public List<GameObject> OBS {
		get {
			return obsList;
		}

	}
	}
