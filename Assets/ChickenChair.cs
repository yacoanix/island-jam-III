using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenChair : MonoBehaviour {

	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Move(Vector2 movement) {
		rb.velocity = movement;
	}
}
