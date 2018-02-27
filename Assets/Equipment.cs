using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Equipment : MonoBehaviour {

	SpriteRenderer spriteRenderer;
	//public TickingClock timer;
	bool isIdle = true;
	Vector3 targetPos;
	float speed = 1.5f;


	// Use this for initialization
	void Start () {
		//timer = GameObject.FindWithTag ("Player").GetComponent<TickingClock>();
		//spriteRenderer = GetComponent <SpriteRenderer> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (this.tag == "DiveEquipments") {
			if (isIdle == true) {
				targetPos = new Vector3 (Random.Range(-10.6f,10.6f),Random.Range(-10.6f,10.6f),Random.Range(-10.6f,10.6f));
				isIdle = false;
				//Debug.Log (targetPos);
			}
			else {
				Vector3 direction = (targetPos-transform.position).normalized;
				Vector3 nextPos = transform.position + direction*speed*Time.deltaTime;
				transform.position = nextPos;
				if (Vector3.Distance(transform.position,targetPos)<speed) {
					isIdle = true;
				}
			}
		}
		if (this.tag == "DangerousThings") {
			if (isIdle == true) {
				targetPos = new Vector3 (Random.Range(-10.6f,10.6f),Random.Range(-10.6f,10.6f),Random.Range(-10.6f,10.6f));
				isIdle = false;
				//Debug.Log (targetPos);
			}
			else {
				Vector3 direction = (targetPos-transform.position).normalized;
				Vector3 nextPos = transform.position + direction*speed*Time.deltaTime;
				transform.position = nextPos;
				if (Vector3.Distance(transform.position,targetPos)<speed) {
					isIdle = true;
				}
			}
		}
		if (this.tag == "DangerousCreatures") {
			if (isIdle == true) {
				targetPos = new Vector3 (Random.Range(-10.6f,10.6f),Random.Range(-10.6f,10.6f),Random.Range(-10.6f,10.6f));
				isIdle = false;
				//Debug.Log (targetPos);
			}
			else {
				Vector3 direction = (targetPos-transform.position).normalized;
				Vector3 nextPos = transform.position + direction*speed*Time.deltaTime;
				transform.position = nextPos;
				if (Vector3.Distance(transform.position,targetPos)<speed) {
					isIdle = true;
				}
			}
		}
	}

	void OnMouseDown(){
		if (this.tag == "DangerousThings") {
			//Destroy (GameObject.FindGameObjectWithTag("Player")); TO destory the player when I click on this stuff
			Destroy (this.gameObject);
		}
		if (this.tag == "DangerousCreatures") {
			Destroy (this.gameObject);
		}

	}

		
}
