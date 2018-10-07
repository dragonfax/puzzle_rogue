using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

	private GameObject m_Player;

	// Use this for initialization
	void Start () {
		m_Player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if ( Time.frameCount % 40 != 0 ) {
			return;
		}

		// move toward player

		int moveX = 0;
		int moveY = 0;

		if ( m_Player.transform.position.x > transform.position.x ) {
			moveX = 1;
		}

		if ( m_Player.transform.position.x < transform.position.x ) {
			moveX = -1;
		}

		if ( m_Player.transform.position.y > transform.position.y ) {
			moveY = 1;
		}

		if ( m_Player.transform.position.y < transform.position.y ) {
			moveY = -1;
		}

		transform.position = transform.position + new Vector3(moveX, moveY, 0);

		
	}
}
