using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject player;

	public Vector3 offset;

	public float moveSpeed = 10f;

	// Use this for initialization
	void Start () {

		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {

		transform.position = player.transform.position + offset;

		/*if (player.transform.position = GameObject.FindWithTag ("Borders")) {
			transform.position
		}*/

	}
}
