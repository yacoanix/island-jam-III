using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroller : MonoBehaviour {

	public Vector2 velocity;
	private SpriteRenderer SpriteToScroll;
	// Use this for initialization
	void Start () {
		SpriteToScroll = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		SpriteToScroll.material.mainTextureOffset += velocity * Time.deltaTime;
		Vector2 offset = SpriteToScroll.material.GetTextureOffset("_MainTex");
		SpriteToScroll.material.SetTextureOffset("_MainTex", offset + velocity * Time.deltaTime);
	}
}
