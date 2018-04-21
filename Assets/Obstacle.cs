using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

	public float damage = 15;
	BackgroundScroll scroll;

	private float offset = 2;

	// Use this for initialization
	void Start () {
		scroll = Camera.main.GetComponent<BackgroundScroll>();
	}
	
	void OnCollisionEnter2D(Collision2D collision) {
		vida playerLife = collision.gameObject.GetComponent<vida>();
		if(playerLife != null) {
			Debug.Log("Choca");
			playerLife.TakeDamage(damage);
			Destroy(gameObject);
		}
	}

	void Update(){
		if(scroll.CameraBounds().x > transform.position.x - offset) {
			Destroy(gameObject);
			Debug.Log("Tengo miedo");
		}
	}
}
