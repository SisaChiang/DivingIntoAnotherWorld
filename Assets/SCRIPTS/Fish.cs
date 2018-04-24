using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Fish : MonoBehaviour {/*

	bool isIdle = true;
	Vector3 targetPos;
	Vector2 newTarget;
	public float speed = 0.5f;

	public GameObject fishPrefab;

	 int numFish = 20;
	public GameObject[] allFish ;


	// Use this for initialization
	void Start () {
		allFish = new GameObject[numFish];
		for (int i = 0; i < numFish; i++) {
			targetPos = new Vector2 (Random.Range(-10f,10f), Random.Range(-10f,10f));
			allFish [i] = (GameObject)Instantiate (fishPrefab, targetPos, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < numFish; i++) {
			newTarget = (Vector2)allFish [i].transform.position + new Vector2 (Random.Range (-5f, 5f), Random.Range (-5f, 5f));
			Vector2 direction = (newTarget - (Vector2)transform.position).normalized;
			allFish [i].transform.position += (Vector3)direction * speed * Time.deltaTime;
		}

	}
*/}
