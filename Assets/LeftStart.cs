using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftStart : MonoBehaviour {

	private float offset = 3.0f;

	// Use this for initialization
	void Start () {
		Vector2 cameraBounds = Camera.main.GetComponent<BackgroundScroll>().CameraBounds();
		
		transform.position = new Vector3(
			cameraBounds.x + offset,
			transform.position.y,
			transform.position.z
		);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
