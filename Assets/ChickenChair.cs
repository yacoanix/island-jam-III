using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ChickenChair : MonoBehaviour {

	Rigidbody2D rb;
	[SerializeField] Vector2 speed = new Vector2(180, 60);

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Move(Vector2 movement) {
		rb.velocity = Vector2.Scale(movement, speed * Time.deltaTime);
	}
}
