using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if ( Time.frameCount % 10 != 0) {
			return;
		}
		float x = Input.GetAxis("Horizontal");	
		float y = Input.GetAxis("Vertical");	

		x = x > 0 ? 1 : x < 0 ? -1 : 0;
		y = y > 0 ? 1 : y < 0 ? -1 : 0;

		transform.position = new Vector3(transform.position.x + x, transform.position.y + y,transform.position.z);
	}
}
