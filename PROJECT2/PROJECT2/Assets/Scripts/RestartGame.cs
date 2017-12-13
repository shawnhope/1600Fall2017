using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartGame : MonoBehaviour {

	public Transform respawnPoint;				//obj'sSpawnPosition duh
	public static Vector3 playerStartPos;			//player's v3 coord. doi
	public GameObject[] expended;					//array for enemies
	public GameObject GameOverUI;
	public GameObject YouWinUI;

	void Awake(){
		playerStartPos = respawnPoint.position;	//for playerPos only 
		GameOverUI.SetActive(false);
	}

	void Click(){
		respawnPoint.position = playerStartPos;
		GameOverUI.SetActive(false);
		CharacterControl.gameOver = false;
		CharacterControl.youWon = false;
		for(int i = 0; i < expended.Length; i++){	//turns on enemies in array on ingame reset
			expended [i].SetActive (true);
			}
		}
	}