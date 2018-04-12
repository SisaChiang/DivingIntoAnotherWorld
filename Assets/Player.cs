using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour {

	public Sprite player; 
	public float attackSpeed = 5.0f; // this is the speed when the player has an attack object
	public float normalSpeed = 2.0f; // this is the speed of the player without the attack object
	float speed; // this will toggle between attackSpeed and normalSpeed depending on what the player has

	SpriteRenderer spriteRenderer;
	public TickingClock timer;


	public Text scoreText;
	public static int score = 0;

	public Sprite Attackplayer;
	float AttackTimeLeft;

	public AudioSource pointsSound;
	public AudioSource hurtSound;
	public AudioSource hitSound;


	// Use this for initialization
	void Start () {
		speed = normalSpeed;
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
			speed = normalSpeed;
		}
	}

	// here below are the codes for colliding with equipments. Not equipment movement.
	void OnTriggerEnter2D(Collider2D CollisionInfo){
		if (CollisionInfo.gameObject.tag == "DiveEquipments" && spriteRenderer.sprite != Attackplayer) {
			timer.timeLeft += 3.0f;
			//Destroy (CollisionInfo.gameObject); //other than destory, just change the position of it. 
			CollisionInfo.gameObject.transform.position = new Vector3 (Random.Range(-15.6f,15.6f),Random.Range(-15.6f,15.6f),Random.Range(-15.6f,15.6f));
			pointsSound.Play ();
		}
		if (CollisionInfo.gameObject.tag == "DangerousThings") {
			if (spriteRenderer.sprite == Attackplayer) {
				Destroy (CollisionInfo.gameObject);
				hitSound.Play ();
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
				hitSound.Play ();
			} 

			else {
				Destroy (CollisionInfo.gameObject);
				timer.timeLeft -= 5.0f;
				CollisionInfo.gameObject.transform.position = new Vector3 (Random.Range (-15.6f, 15.6f), Random.Range (-15.6f, 15.6f), Random.Range (-15.6f, 15.6f));
				hurtSound.Play ();
			}
	    }
		Debug.Log ("Collidedddddd!");
		if (CollisionInfo.gameObject.tag == ("AttackEquipments")) {
			spriteRenderer.sprite = Attackplayer;
			CollisionInfo.gameObject.transform.position = new Vector3 (Random.Range(-15.6f,15.6f),Random.Range(-15.6f,15.6f),Random.Range(-15.6f,15.6f));
			AttackTimeLeft = 5.0f;
			speed = attackSpeed; // speed changes to the faster attack mode speed
			pointsSound.Play ();

		}
		if (CollisionInfo.gameObject.tag == ("Treasure")) {
			SceneManager.LoadScene ("WinScene");
			timer.timeLeft += 15.0f;
			pointsSound.Play ();
		}


	}
		
}
