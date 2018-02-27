using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // inputing the UI library

public class RacastingInput : MonoBehaviour {

	//SpriteRenderer diveSprite;

	//public Text theText;


	// Use this for initialization
	// USE THIS IF NEEDED, MOUSE OVER OBJECTS
	void Start () {

		//diveSprite = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	/*void Update () {

		RaycastHit2D rayCastHit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero); // same as new Vector2 (0,0)

		if (rayCastHit.collider != null) {
		// the ray has hit something with a collider on it
			if (rayCastHit.collider.tag == "DiveEquipments") { // check if the name of the collider matches what we are looking for
				diveSprite.color = Color.blue; // we know are the dive sprites that changes the color.
				theText.text = rayCastHit.collider.tag + "Dive Equipment has been hit";
			} 
			else {
				diveSprite.color = Color.white;
				theText.text = "Something has been hit but it not the diving equipments";
			}

		}
		else {

			diveSprite.color = Color.white;
			theText.text = "Nothing hit";
		}

	}*/
}
