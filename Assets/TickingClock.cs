using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TickingClock : MonoBehaviour {

	SpriteRenderer diveSprite;


	float timeLeft = 5.0f; 
	public Text text; 

	// Use this for initialization
	void start () {


		
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		text.text = "Time Left:" + timeLeft.ToString("####");
		if (timeLeft <= 0) {
			SceneManager.LoadScene ("GameOver");
		}
			
	}
}
