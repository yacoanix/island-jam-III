using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public Transform[] Lanzadores;
	public float TiempoDeDisparos = 0.3f;
	public bool CanFire = true;
    public KeyCode shootKey;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (shootKey) && CanFire){
		    foreach (Transform t in Lanzadores){
				PlayShotSound(t);
		        GetComponent<DisparosGuays>().SpawnAmmo (t.position,t.rotation);
		    }
		    CanFire = false;
		        Invoke ("Reload",TiempoDeDisparos);
		}
	}

	public void Reload(){
	    CanFire = true;
	}

	
    private void PlayShotSound(Transform lanzador) {
		lanzador.GetComponent<AudioSource>().Stop();
		lanzador.GetComponent<AudioSource>().Play();
    }
}
