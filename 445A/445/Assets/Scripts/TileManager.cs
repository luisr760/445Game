﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TileManager : MonoBehaviour 
{
	public GameObject[] tilePrefabs;

	public GameObject currentTile;

	//private GameObject currentItem;

	private static TileManager instance;

	private Stack<GameObject> rightTiles = new Stack<GameObject>();

	private Stack<GameObject> bottomTiles = new Stack<GameObject>();

	public Stack<GameObject> RightTiles
	{
		get { return rightTiles; }
		set { rightTiles = value; }
	}
		
	public Stack<GameObject> BottomTiles
	{
		get { return bottomTiles; }
		set { bottomTiles = value; }
	}

	public static TileManager Instance
	{
		get 
		{
			if (instance == null) //Finds the instance if it doesn't exist
			{
				instance = GameObject.FindObjectOfType<TileManager>();
			}

			return instance; 

		}

	}

	void Start()
	{
		//Creates 100 tiles
	     CreateTiles(20);

	     //Spawns 50 tiles when the game starts
	     for (int i = 0; i < 10; i++)
	     {
	         SpawnTile();
	     }
	         
	 }
 	
     public void CreateTiles(int amount)
     {   

         for (int i = 0; i < amount; i++)
         {   
             rightTiles.Push(Instantiate(tilePrefabs[0]));
             bottomTiles.Push(Instantiate(tilePrefabs[1]));	
			 bottomTiles.Peek().name = "BottomTile";
			 bottomTiles.Peek().SetActive(false);
			 rightTiles.Peek().name = "RightTile";
             rightTiles.Peek().SetActive(false);
             
         }

     }
		
     public void SpawnTile()
     {
         //If we are out of tiles, then we need to create more
         if (rightTiles.Count == 0 || bottomTiles.Count == 0)
         {
             CreateTiles(10);
         }

         //Generating a random number between 0 and 1
         int randomIndex = Random.Range(0, 2);


         if (randomIndex == 0) //If the random number is one then spawn a right tile
         {
             GameObject temp = rightTiles.Pop();
             temp.SetActive(true);
             temp.transform.position = currentTile.transform.GetChild(0).transform.GetChild(randomIndex).position;
             currentTile = temp;
			 //generateItem ();
         }
         else if(randomIndex == 1) //If the random number is one then spawn a bottom tile
         {
             GameObject temp = bottomTiles.Pop();
             temp.SetActive(true);
             temp.transform.position = currentTile.transform.GetChild(0).transform.GetChild(randomIndex).position;
             currentTile = temp;
			 generateItem ();
         }
     } 
	public void generateItem()
	{
		
		List<GameObject> start = GameObject.FindObjectOfType<ItemList>().ITEMS;
		List<GameObject> items = start;
		int index = Random.Range(0,3);
		GameObject currentItem = items [index];

		float x = currentTile.transform.position.x;
		float y = currentTile.transform.position.y;
		float z = currentTile.transform.position.z;

		float height = y + (currentTile.transform.localScale.y + 8);

		Instantiate (currentItem, new Vector3(x,height,z), Quaternion.identity);

	}
	public void ResetGame() {

		Application.LoadLevel(Application.loadedLevel);

	}
}
