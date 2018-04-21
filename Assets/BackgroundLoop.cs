using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour {

	private List<Transform> backgrounds;
	private BackgroundScroll scroll;

	// Use this for initialization
	void Start () {
		backgrounds = new List<Transform>(GetComponentsInChildren<Transform>());
		backgrounds.Remove(transform);
		scroll = Camera.main.GetComponent<BackgroundScroll>();
	}	
	
	// Update is called once per frame
	void Update () {
		foreach (Transform background in backgrounds)
		{
			if(BackgroundIsOutsideCamera(background)) {
				MoveBackground(background);
				break;
			}
			
		}
	}

	bool BackgroundIsOutsideCamera(Transform background){
		Debug.Log(background.name);
		float bgRightSide = background.GetComponent<SpriteRenderer>().bounds.max.x;
		return bgRightSide < scroll.CameraBounds().x;
	}

	void MoveBackground(Transform bg) {
		Transform rightBg = BackgroundOnTheRight();
		float xRightBgSide = rightBg.GetComponent<SpriteRenderer>().bounds.max.x;
		float bgWidth = rightBg.GetComponent<SpriteRenderer>().bounds.size.x;

		bg.position = new Vector3(xRightBgSide + bgWidth / 2.0f,
			bg.position.y, bg.position.z);
	}

	Transform BackgroundOnTheRight() {
		Transform rightBg = backgrounds[0]; 
		foreach (Transform background in backgrounds)
		{
			rightBg = rightBg.position.x > background.position.x? rightBg : background;
		}
		return rightBg;
	}

}
