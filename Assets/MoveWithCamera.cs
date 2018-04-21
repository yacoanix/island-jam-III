using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithCamera : MonoBehaviour {

	public float velocityRatio = 1;
	public Vector3 lastPosition;

	void Start() {
		lastPosition = Camera.main.transform.position;
	}

	// Update is called once per frame
	void Update () {
		Vector3 cameraOffset = Camera.main.transform.position - lastPosition;
		transform.position += cameraOffset * velocityRatio;

		lastPosition = Camera.main.transform.position;
	}
}
