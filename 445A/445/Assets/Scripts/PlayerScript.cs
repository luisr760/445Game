using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {

	public float speed;

	private Vector3 dir;

	private bool isDead;

	public GameObject resetButton;

	private int score = 0;

	public Text scoreText;

	public Animator gameOver;

	public Text highScore;

	public Image background;

	public Text[] scoreTexts;

	public GameObject particles;

	public GameObject PauseUI;

	public int SCORE {
		get{
			return score;
		}
		set{
			score = value;
		}
	}
	public bool IsDead {
		get{
			return isDead;
		}
		set{ isDead = value;}
	}
	void Start() {

		AudioListener.pause = false;
		PauseUI.SetActive (false);
		isDead = false;
		dir = Vector3.zero;

	}

	void Update() {
		scoreText.text = score.ToString ();

		if (Input.GetMouseButtonDown (0) && !isDead) {

			score++;
			//scoreText.text = score.ToString ();

			if (dir == Vector3.back) {

				dir = Vector3.right;

			} else {

				dir = Vector3.back;

			}
		}
		//dir = Vector3.back;
		float amountToMove = speed * Time.deltaTime;
		transform.Translate (dir * amountToMove);
	}

	void OnTriggerExit(Collider other) {

		if (other.tag == "Tile") {

			RaycastHit hit;

			Ray downRay = new Ray (transform.position, -Vector3.up);

			if(!Physics.Raycast(downRay, out hit)) {

				//Kill Player
				Debug.Log ("Hello");
				isDead = true;
				GameOver ();
				resetButton.SetActive (true);
				if (transform.childCount > 2) {
					transform.GetChild (2).transform.parent = null;
				}
			}
		}

	}

	public void DestroyPlayer()
	{
		Destroy(gameObject);
	}

	public void GameOver() {

		gameOver.SetTrigger ("GAMEOVER");
		scoreTexts [1].text = score.ToString ();

		int bestText = PlayerPrefs.GetInt ("BestScore", 0);

		if (score > bestText) {

			PlayerPrefs.SetInt ("BestScore", score);
			highScore.gameObject.SetActive (true);
			background.color = new Color32 (115, 125, 233, 255);
			foreach (Text txt in scoreTexts) {

				txt.color = Color.white;

			}

		}

		scoreTexts[3].text = PlayerPrefs.GetInt ("BestScore", 0).ToString ();
	}

	public void Pause() {

		PauseUI.SetActive (true);
		Time.timeScale = 0.0001f;
		AudioListener.pause = true;
		scoreTexts [1].text = score.ToString ();

		int bestText = PlayerPrefs.GetInt ("BestScore", 0);

		scoreTexts[3].text = PlayerPrefs.GetInt ("BestScore", 0).ToString ();
	}

	public void Resume() {
		
		PauseUI.SetActive (false);
		Time.timeScale = 1;
		AudioListener.pause = false;
	
	}
	
}
