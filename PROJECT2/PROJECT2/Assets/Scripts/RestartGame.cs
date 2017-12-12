using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartGame : MonoBehaviour {

	public Transform[] respawnPoints;	//obj'sSpawnPositions duh
	public GameObject[] thingsToRespawn;						//dur
	public static Vector3 playerStartPos;			//player's v3 coord. doi
	public GameObject GameOverUI;

	void Awake(){
		for (int i = 1; i < thingsToRespawn.Length; i++) {
			Instantiate (thingsToRespawn [i], respawnPoints [i].position, respawnPoints [i].rotation);
		}
		playerStartPos = respawnPoints[0].position;	//for playerPos only [0] is player
		GameOverUI.SetActive(false);
	}

	void Click(){
		respawnPoints[0].position = playerStartPos;
		GameOverUI.SetActive(false);
		CharacterControl.gameOver = false;
		for(int i = 1; i < thingsToRespawn.Length; i++){
			if(Powers.expended){
			Instantiate(thingsToRespawn[i], respawnPoints[i].position, respawnPoints[i].rotation);
			}
		}
	}
}
