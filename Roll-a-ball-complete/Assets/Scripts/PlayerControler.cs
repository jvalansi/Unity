using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControler : MonoBehaviour {

	public float speed;

	private Rigidbody rb;
	private int count;
	public Text countText;
	public Text winText;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		count = 0;
		setCountText ();
		winText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector3 v = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce(v*speed);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);
			count += 1;
			setCountText ();
			if (count == 6) {
				winText.text = "You Win";
			}
		}
	}

	void setCountText(){
		countText.text = "Count: " + count.ToString ();
	}
}
