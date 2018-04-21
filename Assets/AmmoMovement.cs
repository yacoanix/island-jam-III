using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoMovement : MonoBehaviour {

    public float Speed = 4f;
    public float TimeToDie = 10f;


	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position += transform.right * Speed * Time.deltaTime;
		Invoke ("Destroy", TimeToDie);
	}

	public void Destroy(){
	    transform.position = transform.parent.position;
	    gameObject.SetActive (false);
	}
}
