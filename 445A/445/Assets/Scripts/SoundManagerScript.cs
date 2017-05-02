using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {

	public static AudioClip playerHitSound, playerDeathSound, playerEatSound;
	static AudioSource audioSrc;

	// Use this for initialization
	void Start () {
		playerHitSound = Resources.Load<AudioClip> ("hit");
		playerDeathSound = Resources.Load<AudioClip> ("death");
		playerEatSound = Resources.Load<AudioClip> ("eat");

		audioSrc = GetComponent<AudioSource>();

	}

	// Update is called once per frame
	void Update () {

	}

	public static void PlaySound(string clip)
	{
		switch (clip){
			case "hit":
			audioSrc.PlayOneShot (playerHitSound);
			break;
			case "death":
			audioSrc.PlayOneShot (playerDeathSound);
			break;
			case "eat":
			audioSrc.PlayOneShot (playerEatSound);
			break;
		}
	}
}
