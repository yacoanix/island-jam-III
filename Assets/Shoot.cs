using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public Transform[] Lanzadores;
	public float TiempoDeDisparos = 0.3f;
	public bool CanFire = true;


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) && CanFire){
		    foreach (Transform t in Lanzadores){
		        DisparosGuays.SpawnAmmo (t.position,t.rotation);
		    }
		    CanFire = false;
		        Invoke ("Reload",TiempoDeDisparos);
		}
	}

	public void Reload(){
	    CanFire = true;
	}
}
