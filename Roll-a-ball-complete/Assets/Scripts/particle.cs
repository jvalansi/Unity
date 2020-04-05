using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle : MonoBehaviour {

	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb.velocity = new Vector3(10, 0, 10);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
