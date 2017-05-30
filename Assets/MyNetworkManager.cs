using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {


	public void MyStartHost() {
		StartHost();
		Debug.Log("Starting Host at: " + Time.timeSinceLevelLoad);
	}

	public override void OnStartHost() {
		Debug.Log("Host started at: " + Time.timeSinceLevelLoad);
	}

	public override void OnStartClient(NetworkClient myClient) {
		Debug.Log("ClientStart requested at: " + Time.timeSinceLevelLoad);
	}

	public override void OnClientConnect(NetworkConnection conn) {
		Debug.Log("Client connected to IP:" + conn.address +  " at: " + Time.timeSinceLevelLoad);
	}
}
