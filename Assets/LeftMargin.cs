using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMargin : MonoBehaviour {

	public float margin = 4.0f;
	public float damagePerSecond = 80;
	BoxCollider2D boxCollider;

	// Use this for initialization
	void Start () {
		boxCollider = GetComponent<BoxCollider2D>();
		boxCollider.size = new Vector2(margin, Camera.main.orthographicSize * 2.0f);

		SetPositionRelativeToCamera();

	}
	
	// Update is called once per frame
	void Update () {
		SetPositionRelativeToCamera();
	}

	void SetPositionRelativeToCamera() {
		Vector2 cameraBounds = Camera.main.GetComponent<BackgroundScroll>().CameraBounds();
		
		transform.position = new Vector3(
			cameraBounds.x,
			Camera.main.transform.position.y,
			Camera.main.transform.position.z
		);
	}

	void OnCollisionStay2D(Collision2D collision) {
		vida playerLife = collision.gameObject.GetComponent<vida>();
		if(playerLife != null) {
			playerLife.TakeDamage(damagePerSecond * Time.deltaTime);
		}
	}

	void OnTriggerStay2D(Collider2D other) {
		vida playerLife = other.GetComponent<vida>();
		if(playerLife != null) {
			playerLife.TakeDamage(damagePerSecond * Time.deltaTime);
		}
	}

}
