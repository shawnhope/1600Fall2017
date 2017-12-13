using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGamePole : MonoBehaviour {

	public GameObject youWinUI;

	void OnTriggerEnter(){
		print ("WINNER WINNER CHIKN DEeNERD");
		CharacterControl.youWon = true;
		youWinUI.SetActive (true);

	}
}
