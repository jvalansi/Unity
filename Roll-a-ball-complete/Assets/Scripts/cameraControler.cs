using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControler : MonoBehaviour {

	public GameObject player;
	private Vector3 v;

	// Use this for initialization
	void Start () {
		v = transform.position - player.transform.position;
	}
	
	void LateUpdate () {
		transform.position = player.transform.position + v;
	}
}
