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

		Camera.main.GetComponent<CameraMove>().Run(true);	
		StartPlayer(players[0]);
		StartPlayer(players[1]);
	}

	void StartPlayer(GameObject player) {
		player.GetComponent<ChickenControl>().controlActive = true;
		player.GetComponent<Animator>().SetBool("Running", true);
	}

	public void PlayerDies(GameObject player) {
		player.GetComponent<Animator>().SetBool("Dying", true);
		player.GetComponent<ChickenControl>().controlActive = false;
		player.GetComponent<BoxCollider2D>().enabled = false;
		player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;

		fisnished = true;

		GameOver(player.name == "player2");

	}


	bool fisnished = false;

	public void GameOver(bool chickenHawkingsWin) {

	}

}
