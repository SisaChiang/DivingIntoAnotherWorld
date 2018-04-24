using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMananger : MonoBehaviour {

	Vector3 targetPos;
	Vector2 newTarget;
	public float speed = 0.5f;

	public GameObject fishPrefab1;
	public GameObject fishPrefab2;

	public int numFish = 25;
	public GameObject[] allFish ;

	public float minY;
	public float maxY;
	public float minX;
	public float maxX;

	// Use this for initialization
	void Start () {
		allFish = new GameObject[numFish];
		for (int i = 0; i < numFish; i++) {
			targetPos = new Vector2 (Random.Range(-15f,15f), Random.Range(-15f,15f));
			// Random.value returns a random value between 0 and 1
			float randomNum = Random.value;
			//If that random value is grater than .5 spawn the purple fish
			//Otherwise spawn the orange fish

			if (randomNum > .5f) {
				allFish [i] = (GameObject)Instantiate (fishPrefab1, targetPos, Quaternion.identity);
			} else {
				allFish [i] = (GameObject)Instantiate (fishPrefab2, targetPos, Quaternion.identity);
			}
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < numFish; i++) {
			//Chose a new random desitination for the fish to go to 
			//The new desitination is within a random range up 5 units away from the fishes
			//current position
			newTarget = (Vector2)allFish [i].transform.position + new Vector2 (Random.Range (-8f, 8f), Random.Range (-8f, 8f));
			//newTarget = (Vector2)allFish [i].transform.position + new Vector2 (-1,-1);

			Debug.Log ("new target " + i+ " " + newTarget);
			Vector2 heading = (newTarget - (Vector2)transform.position);
			float distance = heading.magnitude;
			Vector2 direction = heading / distance;
			Debug.Log (direction);

			Vector2 newPos = allFish [i].transform.position + (Vector3)direction * speed * Time.deltaTime;
			if (newPos.x > maxX || newPos.x < minX) {
				direction.x = -direction.x;
				Debug.Log ("switch x");
			}
			if (newPos.y > maxY || newPos.y < minY) {
				direction.y = -direction.y;
				Debug.Log ("switch y");
			}
			allFish [i].transform.position += ((Vector3)direction * speed + ((Vector3)newPos -allFish [i].transform.position)) * Time.deltaTime;

		}
	}
}
