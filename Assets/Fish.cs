using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Fish : MonoBehaviour {

	public float speed = 0.8f;

	SpriteRenderer spriteRenderer; 

	// Use this for initialization
	void Start () {

		spriteRenderer = GetComponent<SpriteRenderer> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.right * speed * Time.deltaTime;
		spriteRenderer.flipX = true;
	}
}
