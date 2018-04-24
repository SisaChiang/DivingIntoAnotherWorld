using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubbles : MonoBehaviour {

	public float speed = 0.5f;
	public GameObject bubblesPrefab;
	public int Numbubbles = 10;
	public GameObject [] Allbubbles;
	Vector3 Position;


	// Use this for initialization
	void Start () {
		Allbubbles = new GameObject[Numbubbles];
		for (int i = 0; i < Numbubbles; i++) {
			Position = new Vector2 (Random.Range (-10f,10f), Random.Range(-10f,10f));
			transform.position = Position;
			Allbubbles [i] = (GameObject)Instantiate (bubblesPrefab, Position, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
