using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGamePole : MonoBehaviour {

	public GameObject youWinUI, particle;

	void Awake(){
		youWinUI.SetActive (false);			//i feel like some of this has gotta be unnecessary
	}										//but I'm at the point where I don't dare touch anything, man

	void OnTriggerEnter(){
		print ("WINNER WINNER CHKN DNR");
		particle.SetActive (true);
		CharacterControl.youWon = true;
		youWinUI.SetActive (true);

	}
}
