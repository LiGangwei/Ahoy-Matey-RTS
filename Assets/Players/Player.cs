using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;

public class Player : NetworkBehaviour {
	public float speed = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(isLocalPlayer) {
			transform.position += new Vector3(CrossPlatformInputManager.GetAxis("Horizontal")*speed*Time.deltaTime, CrossPlatformInputManager.GetAxis("Vertical")*speed*Time.deltaTime, 0f);
		}
	}
}
