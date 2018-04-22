using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeLower : MonoBehaviour {

	AudioSource song;
	public float silenceAt = 20.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//song.volume -= Time.deltaTime / silenceAt;
	}
}
