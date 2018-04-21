using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChickenControl : MonoBehaviour {

	[SerializeField] private KeyCode up;
	[SerializeField] private KeyCode down;
	[SerializeField] private KeyCode left;
	[SerializeField] private KeyCode right;

	private ChickenChair chair;

	// Use this for initialization
	void Start () {
		chair = GetComponent<ChickenChair>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 move = Vector3.zero;
		if(Input.GetKeyDown(up)) move += Vector2.up;
		if(Input.GetKeyDown(down)) move += Vector2.down;
		if(Input.GetKeyDown(right)) move += Vector2.right;
		if(Input.GetKeyDown(left)) move += Vector2.left;

		chair.Move(move);
	}
}
