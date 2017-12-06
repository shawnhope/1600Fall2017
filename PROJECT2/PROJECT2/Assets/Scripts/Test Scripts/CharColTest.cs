using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharColTest : MonoBehaviour {

	void OnControllerColliderHit(ControllerColliderHit hit){
		if (hit.rigidbody == true) {
			print ("controller hit!");
		}
	}
}
