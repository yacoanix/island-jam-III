using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Spawner : MonoBehaviour {

	private BoxCollider2D box;
	[SerializeField] private float minSpawnTime = 1;
	[SerializeField] private float maxSpawnTime = 4;

	[SerializeField] private GameObject[] spawnables;
	public bool spawn = true;

	// Use this for initialization
	void Start () {
		box = GetComponent<BoxCollider2D>();
		StartCoroutine(SpawnCorutine());
	}
	
	IEnumerator SpawnCorutine() {
		while(spawn) {
			yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
			if(spawnables.Length != 0) {
				Spawn(spawnables[Random.Range(0, spawnables.Length)]);
			}
		}
	}

	public GameObject Spawn(GameObject spawnable) {
		Bounds bound = box.bounds;
		Vector3 randomPoint = new Vector3(
		 Random.Range(bound.min.x, bound.max.x),
		 Random.Range(bound.min.y, bound.max.y),
		 spawnable.transform.position.z
		);
		
		return Instantiate(spawnable, randomPoint, Quaternion.identity);
	}
}
