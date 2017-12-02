using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {
	public GameObject shot;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			GameObject newShot = Instantiate(shot, transform.position, transform.rotation);
//			Vector2 position = newShot.transform.position;
//			Vector2.MoveTowards()
//			newShot += newShot.transform.up. * newShot.GetComponent<SpriteRenderer>().size.y / 2;
		}
	}
}
