using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;

public class Player : NetworkBehaviour {
	public float speed = 10;

	// Update is called once per frame
	void Update () {
		if(!isLocalPlayer) {
			return;
		}
		transform.Translate(new Vector3(CrossPlatformInputManager.GetAxis("Horizontal")*speed*Time.deltaTime, 0f, CrossPlatformInputManager.GetAxis("Vertical")*speed*Time.deltaTime));
	}

	public override void OnStartLocalPlayer() {
		if(transform.childCount <= 0) {
			Debug.LogError("Missing child on player!");
		} else if(transform.GetChild(0).gameObject.activeSelf == true) {
			Debug.LogError("Camera already active! Check prefab child active state.");
		} else {
			transform.GetChild(0).gameObject.SetActive(true);
		}
	}
}
