using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour {

	public Transform[] players;
	public Transform mainCamera;
	private float lastMedia = 0;
	public float offset = 1; 
	public float speed = 3;

	// Use this for initialization
	void Awake () {
		mainCamera = Camera.main.transform;
	}
	
	// Update is called once per frame
	void Update () {
		
		float media = (players[0].position.x + players[1].position.x) / 2.0f;
		
		if(PlayerNearTheFrontBound(players[0]) || PlayerNearTheFrontBound(players[1])) {
			float maxPlayer = Mathf.Max(players[0].position.x, players[1].position.x);
			Vector3 newPosition = new Vector3(
				maxPlayer - GetHorzExtent() + offset, 
				mainCamera.position.y, 
				mainCamera.position.z);

			if(mainCamera.position.x < newPosition.x) {
				mainCamera.position = newPosition;
			}
			
		}else if(mainCamera.position.x < media) {
			SetCameraPosition(media);
		}

		



	}

	public float GetHorzExtent() {
		return Camera.main.orthographicSize * Screen.width / Screen.height;
	}

	public Vector2 CameraBounds() {
		float horzExtent = GetHorzExtent();
		return new Vector2(mainCamera.position.x - horzExtent, mainCamera.position.x + horzExtent);
	}

	public bool PlayerNearTheFrontBound(Transform player) {
		return player.position.x + offset > CameraBounds().y;
	}

	public void SetCameraPosition(float hPosition) {
		float newX = Mathf.Lerp(mainCamera.position.x, hPosition, Time.deltaTime * speed);
		mainCamera.position = new Vector3(newX, mainCamera.position.y, mainCamera.position.z);
	}
}
