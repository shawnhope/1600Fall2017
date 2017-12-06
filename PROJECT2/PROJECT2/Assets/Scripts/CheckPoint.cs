using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

	void OnTriggerEnter(){
		print ("triggerhit");
		RestartGame.startPos = transform.position;
	}

}
