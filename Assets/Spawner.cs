﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	private BoxCollider2D box;

	// Use this for initialization
	void Start () {
		box = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
