﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartGame : MonoBehaviour {

	public Transform player;	//player'sPos duh
	public static Vector3 startPos;
<<<<<<< Updated upstream
=======
	public static GameObject GameOverUI;
>>>>>>> Stashed changes

	void Awake(){
		startPos = player.position;
	}

	void Click(){
		player.position = startPos;
	}
}
