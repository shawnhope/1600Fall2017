using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestartGame : MonoBehaviour {

	public Transform player;	//player'sPos duh
	public static Vector3 startPos;
	public GameObject GameOverUI;

	void Awake(){
		startPos = player.position;
		GameOverUI.SetActive (false);
	}

	public void Click(){
		player.position = startPos;
		GameOverUI.SetActive (false);
	}
}
