using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemList : MonoBehaviour {

	private List<GameObject> itemList; 
	public GameObject item1;
	public GameObject item2;
	public GameObject item3;

	void Awake()
	{
		itemList = new List<GameObject> ();
		itemList.Add (item1);
		itemList.Add (item2);
		itemList.Add (item3);
	}
	public List<GameObject> ITEMS {
		get {
			return itemList;
		}
			
	}
}
