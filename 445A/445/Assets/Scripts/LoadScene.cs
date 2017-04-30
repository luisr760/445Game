using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	public int sceneIndex;
	public string sceneName;
	public void LoadByName()
	{
		SceneManager.LoadScene (sceneName);
	}
	public void LoadByIndex()
	{
		SceneManager.LoadScene(sceneIndex);
	}
	public void Quit()
	{
		Application.Quit();
	}
}
