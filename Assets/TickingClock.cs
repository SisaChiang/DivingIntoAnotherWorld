using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TickingClock : MonoBehaviour {

	public static float score = 0;
	public GameObject sharkPrefab;
	int sharkSpawn;

	public float timeLeft = 10.0f; 
	public Text text; 
	public Text Scoretext;

	public static string highscoreKey = "High Score:";
	public float highScore;

	// Use this for initialization
	void start () {

		highScore = PlayerPrefs.GetFloat (highscoreKey, 0);

	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		text.text = "Time left: " + timeLeft.ToString("####");
		if (timeLeft <= 0) {
			SceneManager.LoadScene ("GameOver");
		}
		if (timeLeft <= 5) {
			text.text = "Warning: " + timeLeft.ToString ("####"); 
		}
		if (timeLeft > 0) {
			score += Time.deltaTime;
		}	
		Scoretext.text = "You've survived for: " + score.ToString("####");
		if (score > highScore) {
			PlayerPrefs.SetFloat (highscoreKey, score);
			PlayerPrefs.Save();
		}
		if (score > 30f && sharkSpawn < 7) {
			
			Instantiate (sharkPrefab, new Vector3 (Random.Range(-20.6f,15.6f),Random.Range(-20.6f,20.6f),Random.Range(-20.6f,20.6f)), Quaternion.identity);
			sharkSpawn += 1;

			if (score> 30f){
				sharkSpawn = 10;
				Debug.Log ("yes");
			}

		}


	}
}
