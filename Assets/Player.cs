using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour {

	public float speed = 1.8f;

	SpriteRenderer spriteRenderer;
	public TickingClock timer;


	public Text scoreText;
	public static int score = 0;



	// Use this for initialization
	void Start () {
		timer =  this.GetComponent<TickingClock>();
		spriteRenderer = GetComponent <SpriteRenderer> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.position += Vector3.up * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position += Vector3.left * speed * Time.deltaTime;

			spriteRenderer.flipX = false;
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.position += Vector3.down * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position += Vector3.right * speed * Time.deltaTime;

			spriteRenderer.flipX = true;
		}

		if (transform.position.x >= 20f) {
			transform.position = new Vector3 (20, transform.position.y, transform.position.z);
		}
		if (transform.position.x <= -20f) {
			transform.position = new Vector3(-20,transform.position.y,transform.position.z);
		}
		if (transform.position.y >= 20f) {
			transform.position = new Vector3(transform.position.x,20,transform.position.z);
		}
		if (transform.position.y <= -20f) {
			transform.position = new Vector3(transform.position.x, -20, transform.position.z);
		}

	}
	void OnTriggerEnter2D(Collider2D CollisionInfo){
		if (CollisionInfo.gameObject.tag == "DiveEquipments") {
			Destroy (CollisionInfo.gameObject);
			timer.timeLeft += 5.0f;
		}
		if (CollisionInfo.gameObject.tag == "DangerousThings") {
			//Destroy (GameObject.FindGameObjectWithTag("Player")); TO destory the player when I click on this stuff
			SceneManager.LoadScene ("GameOver");
		}
		if (CollisionInfo.gameObject.tag == "DangerousCreatures") {
			Destroy (CollisionInfo.gameObject);
			timer.timeLeft-= 5.0f;
		}
		Debug.Log ("Collidedddddd!");

	}	
}
