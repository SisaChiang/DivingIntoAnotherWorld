using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour {

	static bool AudioBegin = false; 
	public AudioSource audio1;

	void Awake(){
		if (!AudioBegin) {
			audio1.Play ();
			DontDestroyOnLoad (gameObject);
			AudioBegin = true;
		}
	
	}

	// Use this for initialization
	void Start () {
		
		
	}


	// Update is called once per frame
	void Update () {
		// need this when need to stop the music when loaded certain scene
		/*if(Application.loadedLevelName == "MainMenu")
		{
			audio1.Stop();
			AudioBegin = false;
		}*/
		
	}
}
