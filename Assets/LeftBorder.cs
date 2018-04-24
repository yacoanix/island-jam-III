using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftBorder : MonoBehaviour {

	float width;

	// Use this for initialization
	void Start () {
		width = GetComponent<SpriteRenderer>().sprite.bounds.size.x * transform.localScale.x;
	}
	
	// Update is called once per frame
	void Update () {
		SetPositionRelativeToCamera();
	}

	void SetPositionRelativeToCamera() {
		Vector2 cameraBounds = Camera.main.GetComponent<BackgroundScroll>().CameraBounds();
		
		transform.position = new Vector3(
			cameraBounds.x + width / 2.0f,
			transform.position.y,
			transform.position.z
		);
	}
}
