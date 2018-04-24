using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


// This script is where I will store all the buttons and switch scenes

public class canvasManager : MonoBehaviour {

	public Text myText;
	public AudioSource button;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (button.isPlaying) {
			Debug.Log ("PLaying");
		}
	}

	public void OnButtonPressed(){
		Debug.Log ("The button is Pressed!");
		button.PlayOneShot(button.clip);
		StartCoroutine(ChangeScene("MainScene"));
		//SceneManager.LoadScene ("MainScene");
		TickingClock.score = 0;

	}

	public void OnButtonPressed2(){
		button.PlayOneShot(button.clip);
		StartCoroutine(ChangeScene("MainScene"));
		//SceneManager.LoadScene ("MainScene");
		TickingClock.score = 0;
	}

	public void OnButtonPressed3(){
		button.PlayOneShot(button.clip);
		StartCoroutine(ChangeScene("Instructions"));
		//SceneManager.LoadScene ("Instructions");
	}

	public void GameOverbutton(){
		button.PlayOneShot(button.clip);
		StartCoroutine(ChangeScene("MainMenu"));
		//SceneManager.LoadScene ("MainMenu");
		TickingClock.score = 0;
	}

	public void StorybuttonPressed(){
		button.PlayOneShot(button.clip);
		StartCoroutine(ChangeScene("Instructions"));
		//SceneManager.LoadScene ("Instructions");
	}

	public void LeadtoStorybutton(){
		button.PlayOneShot(button.clip);
		StartCoroutine(ChangeScene("Story"));
		//SceneManager.LoadScene ("Story");
	}

	public void WinPageButton1(){
		button.PlayOneShot(button.clip);
		StartCoroutine(ChangeScene("MainMenu"));
		//SceneManager.LoadScene ("MainMenu");
	}

	public void WinPageButton2(){
		button.PlayOneShot(button.clip);
		StartCoroutine(ChangeScene("MainScene"));
		//SceneManager.LoadScene ("MainScene");
	}
		
	IEnumerator ChangeScene(string sceneName){
		button.PlayOneShot (button.clip);
		yield return new WaitForSeconds(0.5f);
		SceneManager.LoadScene (sceneName);
	}

}
