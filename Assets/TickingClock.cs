using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TickingClock : MonoBehaviour {

	public static int score = 0;

	public float timeLeft = 10.0f; 
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
		if (timeLeft <= 5) {
			text.text = "Warning:" + timeLeft.ToString ("####"); 
		}
			
	}
}
