using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectEnemy : MonoBehaviour {

	private Camera m_Camera;
	private Transform selectedEnemy;


	// Use this for initialization
	void Start () {
		m_Camera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetButton("Fire1") ) {
			 RaycastHit2D hit = Physics2D.Raycast(new Vector2(m_Camera.ScreenToWorldPoint(Input.mousePosition).x,m_Camera.ScreenToWorldPoint(Input.mousePosition).y), Vector2.zero, 0f);
			 selectedEnemy = hit.transform;
		}

		if ( selectedEnemy != null ) {

			Vector2 mouseMove = PlayerMove.MouseIntMove();

			if ( mouseMove != new Vector2(0,0) ) {
				// swap the enemy position
				selectedEnemy.position = selectedEnemy.position + new Vector3(mouseMove.x,mouseMove.y,0);
				selectedEnemy = null;

				// TODO identify if 3 are in a row.
			}
		}
	}
}
