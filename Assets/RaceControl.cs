using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceControl : MonoBehaviour {

	public Animation animation;
	public GameObject[] players;
	public static RaceControl main;

	// Use this for initialization
	void Start () {
		main = this;
		StartCoroutine(RaceStart());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator RaceStart() {
		animation.Play();
		yield return new WaitForSeconds(animation.clip.length);
		Debug.Log("Oli");	
		StartPlayer(players[0]);
		StartPlayer(players[1]);
	}

	void StartPlayer(GameObject player) {
		player.GetComponent<ChickenControl>().controlActive = true;
		player.GetComponent<Animator>().SetBool("Running", true);
	}

	public void PlayerDies(GameObject player) {
		player.GetComponent<Animator>().SetBool("Dying", true);
	}

}
