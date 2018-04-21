using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida : MonoBehaviour {
    public float vidaPollo = 100;
    public RectTransform ui;
    private Vector2 initialSize;
    AudioSource playerAudio;


    void Awake(){
        
    }

	void Start () {
		initialSize = ui.sizeDelta;

	}

	void Update () {
		ui.sizeDelta = new Vector2(initialSize.x * vidaPollo / 100, initialSize.y);
	}

    public void TakeDamage(float damage) {
        if(playerAudio)
            playerAudio.Play();
        vidaPollo = Mathf.Max(0, vidaPollo - damage);
    }

}
