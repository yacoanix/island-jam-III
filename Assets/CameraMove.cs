using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

	public float speed = 30.0f;
	private bool run = false;

	public void Run(bool b) {
		run = b;
	}
	
	// Update is called once per frame
	void Update () {
		if(run)
			transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
	}

}
