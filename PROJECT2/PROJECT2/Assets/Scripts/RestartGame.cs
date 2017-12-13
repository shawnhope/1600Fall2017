using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestartGame : MonoBehaviour {

	public Transform respawnPoint;				//obj'sSpawnPosition duh
	public static Vector3 playerStartPos;			//player's v3 coord. doi
	public GameObject[] expended, useditems, block;					//array for enemies
	public GameObject GameOverUI;
	public GameObject winPole, youWinUI;

	void Awake(){
		playerStartPos = respawnPoint.position;	//for playerPos only 
		GameOverUI.SetActive(false);
	}

	void Click(){		
		GameOverUI.SetActive(false);
		youWinUI.SetActive (false);
		CharacterControl.gameOver = false;
		CharacterControl.youWon = false;
		winPole.SetActive (false);
		respawnPoint.position = playerStartPos;
		for(int i = 0; i < expended.Length; i++){	//turns on enemies in array on ingame reset
			expended [i].SetActive (true);
			}
		foreach (GameObject usedblock in block) {
			usedblock.SetActive(false);
		}
		foreach (GameObject usedUps in useditems) {
				usedUps.SetActive (true);
			}
		}
	/*void Update(){											//was going to have enemies defeated give points toward score in an array
		foreach (GameObject enemy in expended) {				//couldn't quite wrap my head around it
			if (enemy){
				if(CharacterControl.youWon ==true){
					//add to score
					totalCoinValue = int.Parse(coinNum.text); 			
					int tempAmount = totalCoinValue + coinValue; 		
					while (totalCoinValue <= tempAmount) { 				
						coinNum.text = (totalCoinValue++).ToString (); 
					}
				}
			}
		}
	}*/
}