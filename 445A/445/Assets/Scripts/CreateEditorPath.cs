using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEditorPath : MonoBehaviour {

	private GameObject point1;
	private GameObject point2;

	private List<GameObject> points;
	//Way point manager;
	private TileManager wpManager;
	// Use this for initialization
	void Wake () 
	{
		points = new List<GameObject> ();
		wpManager = GetComponent<TileManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void createWayPoint()
	{
		
	}
	public void addPointObject(GameObject item)
	{
		points.Add (item);
	}
	public List<GameObject> POINTS{
		get{
			return points;
		}
	}
	public GameObject POINT1 {
		get{
			return point1;
		}
	}
	public GameObject POINT2 {
		get{
			return point2;
		}
	}
}
