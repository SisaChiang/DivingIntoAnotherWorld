using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Equipment : MonoBehaviour {

	SpriteRenderer spriteRenderer;
	public TickingClock timer;



	// Use this for initialization
	void Start () {
		timer = GameObject.FindWithTag ("Player").GetComponent<TickingClock>();
		spriteRenderer = GetComponent <SpriteRenderer> ();

	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetMouseButtonDown (0)) {
//			if (GetComponent<Collider> ().tag == "DiveEquipments") {
//				Destroy ();
//			}
//
//		}
		
	}


	void OnMouseDown(){
		if (this.tag == "DiveEquipments") {
			Destroy (this.gameObject);
			timer.timeLeft += 5.0f;
		}
		if (this.tag == "DangerousThings") {
			//Destroy (GameObject.FindGameObjectWithTag("Player")); TO destory the player when I click on this stuff
			SceneManager.LoadScene ("GameOver");
		}

	}


		
}
