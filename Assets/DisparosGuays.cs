using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparosGuays : MonoBehaviour {

       public int municion = 100;
       public GameObject AmmoPrefab;
       public GameObject[] AmmoArray;
       public Queue<Transform> ammoQueue = new Queue<Transform> ();
       public static DisparosGuays ammospawner;



	void Start () {
	    AmmoArray = new GameObject[municion];

        ammospawner = this;
        for (int i = 0; i< municion;i++){
            GameObject Ammo = (GameObject) Instantiate (AmmoPrefab, transform.position, Quaternion.identity);
            Transform Tammo = Ammo.transform;
            ammoQueue.Enqueue (Tammo);
            Ammo.SetActive (false);
            AmmoArray[i] = Ammo;
        }
	}
	

	void Update () {
		
	}

    public static Transform SpawnAmmo (Vector3 position, Quaternion Rotation)
    {
        Transform Ammo = ammospawner.ammoQueue.Dequeue ();
        Ammo.gameObject.SetActive (true);
        Ammo.position = position;
        Ammo.rotation = Rotation;
        ammospawner.ammoQueue.Enqueue (Ammo);

        return Ammo;
    }

}
