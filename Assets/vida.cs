using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida : MonoBehaviour {
       public int vidaPollo = 100;
       public RectTransform ui;
       private Vector2 initialSize;

	// Use this for initialization
	void Start () {
		initialSize = ui.sizeDelta;
	}
	
	// Update is called once per frame
	void Update () {
		ui.sizeDelta = new Vector2(initialSize.x * vidaPollo / 100, initialSize.y);
	}
}
