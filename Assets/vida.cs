using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida : MonoBehaviour {
       public int vidaPollo = 100;
       public int vidaPolloAct;
       public RectTransform ui;
       private Vector2 initialSize;
       AudioSource playerAudio;

       bool damaged;

    void Awake(){
        playerAudio.GetComponent<AudioSource>();
        vidaPolloAct=vidaPolloAct;
    }

	void Start () {
		initialSize = ui.sizeDelta;

	}



	void Update () {
		ui.sizeDelta = new Vector2(initialSize.x * vidaPolloAct / 100, initialSize.y);
	}
}
