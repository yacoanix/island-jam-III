using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida : MonoBehaviour {
    public float vidaPollo = 100;
    public RectTransform ui;
    private Vector2 initialSize;
    AudioSource playerAudio;

    public AudioClip[] cackles;

    void Awake(){
        
    }

	void Start () {
		initialSize = ui.sizeDelta;
        playerAudio = GetComponent<AudioSource>();
	}

	void Update () {
		ui.sizeDelta = new Vector2(initialSize.x * vidaPollo / 100, initialSize.y);
	}

    public void TakeDamage(float damage) {
        if(damage == 0) 
            return;
            
        if(playerAudio != null && !playerAudio.isPlaying)
            PlayCackle();
        vidaPollo = Mathf.Max(0, vidaPollo - damage);

        if(vidaPollo == 0) {
            RaceControl.main.PlayerDies(gameObject);
        }
    }

    public void PlayCackle() {
        playerAudio.clip = cackles[Random.Range(0, cackles.Length)];
        playerAudio.Play();
    }

}
