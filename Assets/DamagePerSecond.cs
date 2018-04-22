using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePerSecond : MonoBehaviour {

	public float damagePerSecond;

	void OnTriggerStay2D(Collider2D other) {
		vida life = other.GetComponent<vida>();
		if(life != null) {
			life.TakeDamage(damagePerSecond * Time.deltaTime);
		}
	}

}
