using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

	void OnTriggerEnter(){
		print ("Check Point!");
		RestartGame.playerStartPos = transform.position;  //makes checkpoint the reference of restartgame's playerStartPos
	}

}
