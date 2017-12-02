using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoreController : MonoBehaviour {
	public float speedMulti;
	public float maxSpeed;
	public float rotSpeed;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A)) {
			rb2d.AddTorque(rotSpeed);
		}
		if (Input.GetKey(KeyCode.D)) {
			rb2d.AddTorque(-rotSpeed);
		}
		
		if (Input.GetKey(KeyCode.W) && rb2d.velocity.magnitude < maxSpeed) {
			rb2d.AddForce(transform.up * speedMulti);
		}
	}
}
