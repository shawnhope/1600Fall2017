using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartGame : MonoBehaviour {

	public Transform player;	//player'sPos duh
	public static Vector3 startPos;

	void Awake(){
		startPos = player.position;
	}

	void Click(){
		player.position = startPos;
	}
}
