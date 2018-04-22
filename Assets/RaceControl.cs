using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RaceControl : MonoBehaviour {

	public Animation startAnimation;
	public Animation winAnimation;
	public GameObject[] players;
	public static RaceControl main;

	public GameObject loserImg;
	public GameObject winnerImg;
	public GameObject textFinish;

	public Sprite[] loserSprites;
	public Sprite[] winnerSprites;

	public float timeOut = 3.0f;

	// Use this for initialization
	void Start () {
		main = this;
		StartCoroutine(RaceStart());
	}
	
	IEnumerator RaceStart() {
		startAnimation.Play();
		yield return new WaitForSeconds(startAnimation.clip.length);

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
		
		if(!fisnished)
			GameOver(player.name == "player2");

		fisnished = true;

	}


	bool fisnished = false;

	public void GameOver(bool chickenHawkingsWin) {
		int winIndex = chickenHawkingsWin? 0 : 1;
		int loseIndex = chickenHawkingsWin? 1 : 0;

		winnerImg.SetActive(true);
		loserImg.SetActive(true);
		textFinish.SetActive(true);

		winnerImg.GetComponent<UnityEngine.UI.Image>().sprite = winnerSprites[winIndex];
		loserImg.GetComponent<UnityEngine.UI.Image>().sprite = loserSprites[loseIndex];

		textFinish.GetComponent<UnityEngine.UI.Text>().text = 
			(!chickenHawkingsWin? "sChicken Hawking " : "Impollator Furioso") + " lose";

		StartCoroutine(RaceFinish());
	}

	IEnumerator RaceFinish() {
		winAnimation.Play();
		yield return new WaitForSeconds(winAnimation.clip.length + timeOut);

		SceneManager.LoadSceneAsync("race");

	}

	void Update() {
		if(Input.GetKeyDown(KeyCode.Escape)) {
			UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
		}

	}

}
