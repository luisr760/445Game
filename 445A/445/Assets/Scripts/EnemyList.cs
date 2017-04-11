using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyList : MonoBehaviour {

	private List<GameObject> itemList; 
	public GameObject item1;
	public GameObject item2;
	public GameObject item3;
	public GameObject item4;
	// Use this for initialization
	void Awake()
	{
		itemList = new List<GameObject> ();
		itemList.Add (item1);
		itemList.Add (item2);
		itemList.Add (item3);
		itemList.Add (item4);
	}
	public List<GameObject> ITEMS {
		get {
			return itemList;
		}

	}
}
