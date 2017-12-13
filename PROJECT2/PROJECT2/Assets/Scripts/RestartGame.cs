using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartGame : MonoBehaviour {

	public Transform respawnPoint;				//obj'sSpawnPosition duh
	public static Vector3 playerStartPos;			//player's v3 coord. doi
	public GameObject GameOverUI;

	void Awake(){
		playerStartPos = respawnPoint.position;	//for playerPos only 
		GameOverUI.SetActive(false);
	}

	void Click(){
		respawnPoint.position = playerStartPos;
		GameOverUI.SetActive(false);
		CharacterControl.gameOver = false;
			}
		}