﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour {


	public float highscore;
	public Text scoreText;

	// Use this for initialization
	void Start () {

		highscore = PlayerPrefs.GetFloat(TickingClock.highscoreKey);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (highscore);
		scoreText.text = highscore.ToString("####")+ "  seconds";

		if (Input.GetKey (KeyCode.Space)) {
			SceneManager.LoadScene ("MainScene");
		
		}
	}
}
