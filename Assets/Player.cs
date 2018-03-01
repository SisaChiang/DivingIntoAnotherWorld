using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour {

	public Sprite player; 
	public float speed = 1.8f;

	SpriteRenderer spriteRenderer;
	public TickingClock timer;


	public Text scoreText;
	public static int score = 0;

	public Sprite Attackplayer;
	float AttackTimeLeft;


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

		if (transform.position.x >= 25f) {
			transform.position = new Vector3 (25, transform.position.y, transform.position.z);
		}
		if (transform.position.x <= -25f) {
			transform.position = new Vector3(-25,transform.position.y,transform.position.z);
		}
		if (transform.position.y >= 25f) {
			transform.position = new Vector3(transform.position.x,25,transform.position.z);
		}
		if (transform.position.y <= -25f) {
			transform.position = new Vector3(transform.position.x, -25, transform.position.z);
		}

		AttackTimeLeft -= Time.deltaTime;
		if (AttackTimeLeft <= 0) {
			spriteRenderer.sprite = player;
		}
	}

	// here below are the codes for colliding with equipments. Not equipment movement.
	void OnTriggerEnter2D(Collider2D CollisionInfo){
		if (CollisionInfo.gameObject.tag == "DiveEquipments" && spriteRenderer.sprite != Attackplayer) {
			timer.timeLeft += 3.0f;
			//Destroy (CollisionInfo.gameObject); //other than destory, just change the position of it. 
			CollisionInfo.gameObject.transform.position = new Vector3 (Random.Range(-15.6f,15.6f),Random.Range(-15.6f,15.6f),Random.Range(-15.6f,15.6f));
		}
		if (CollisionInfo.gameObject.tag == "DangerousThings") {
			if (spriteRenderer.sprite == Attackplayer) {
				Destroy (CollisionInfo.gameObject);
			} 
			else {
				//Destroy (GameObject.FindGameObjectWithTag("Player")); TO destory the player when I click on this stuff
				SceneManager.LoadScene ("GameOver");
				CollisionInfo.gameObject.transform.position = new Vector3 (Random.Range (-15.6f, 15.6f), Random.Range (-15.6f, 15.6f), Random.Range (-15.6f, 15.6f));
			}
		}
		if (CollisionInfo.gameObject.tag == "DangerousCreatures") {
			if (spriteRenderer.sprite == Attackplayer) {
				Destroy (CollisionInfo.gameObject);
			} 

			else {
				Destroy (CollisionInfo.gameObject);
				timer.timeLeft -= 5.0f;
				CollisionInfo.gameObject.transform.position = new Vector3 (Random.Range (-15.6f, 15.6f), Random.Range (-15.6f, 15.6f), Random.Range (-15.6f, 15.6f));
			}
	    }
		Debug.Log ("Collidedddddd!");
		if (CollisionInfo.gameObject.tag == ("AttackEquipments")) {
			spriteRenderer.sprite = Attackplayer;
			CollisionInfo.gameObject.transform.position = new Vector3 (Random.Range(-15.6f,15.6f),Random.Range(-15.6f,15.6f),Random.Range(-15.6f,15.6f));
			AttackTimeLeft = 5.0f;
		}


	}




}
