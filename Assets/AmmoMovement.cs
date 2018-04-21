using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoMovement : MonoBehaviour {

    public float Speed = 1f;
    public float TimeToDie = 5f;


	void Start () {
		StartCoroutine(Callback());
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position += transform.right * Speed * Time.deltaTime;
	}

    IEnumerator Callback() {
        yield return new WaitForSeconds(TimeToDie);
        gameObject.SetActive(false);
    }

}
