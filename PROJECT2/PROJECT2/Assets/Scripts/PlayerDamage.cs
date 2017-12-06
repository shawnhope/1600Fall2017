using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour {

	public GameObject[] player;
	public Transform playerPos;

	void Update(){
		if (Powers.twranched == true) {
			player [0].transform.position = playerPos.position;
		} 
		else if (Powers.twranched == false) {
			player [1].transform.position = playerPos.position;
		}
	}
	//way to swap between array
	//way to trigger the swap

}
