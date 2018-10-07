using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public static Vector2 MouseIntMove() {
		float x = Input.GetAxis("Horizontal");	
		float y = Input.GetAxis("Vertical");	

		x = x > 0 ? 1 : x < 0 ? -1 : 0;
		y = y > 0 ? 1 : y < 0 ? -1 : 0;

		return new Vector2(x,y);
	}
	
	// Update is called once per frame
	void Update () {

		if ( Time.frameCount % 10 != 0) {
			return;
		}

		Vector2 mouseMove = MouseIntMove();
		transform.position = new Vector3(transform.position.x + mouseMove.x, transform.position.y + mouseMove.y,transform.position.z);
	}
}
