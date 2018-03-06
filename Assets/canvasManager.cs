using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


// This script is where I will store all the buttons and switch scenes

public class canvasManager : MonoBehaviour {

	public Text myText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void OnButtonPressed(){
		Debug.Log ("The button is Pressed!");
		SceneManager.LoadScene ("MainScene");
		TickingClock.score = 0;
	}

	public void OnButtonPressed2(){
		SceneManager.LoadScene ("MainScene");
		TickingClock.score = 0;
	}

	public void OnButtonPressed3(){
		SceneManager.LoadScene ("Instructions");
	}

	public void GameOverbutton(){
		SceneManager.LoadScene ("MainMenu");
		TickingClock.score = 0;
	}

	public void StorybuttonPressed(){
		SceneManager.LoadScene ("Instructions");
	}

	public void LeadtoStorybutton(){
		SceneManager.LoadScene ("Story");
	}

	public void WinPageButton1(){
		SceneManager.LoadScene ("MainMenu");
	}

	public void WinPageButton2(){
		SceneManager.LoadScene ("MainScene");
	}
		
}
