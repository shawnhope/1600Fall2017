using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyPatrol : MonoBehaviour {

	public Transform patrolPoint;

	void OnTriggerEnter(Collider other){
		if(other.gameObject.name != "player"){		//makes sure player hitting them doesn't trigger destination change
			enemyNav.destination = patrolPoint;  //grabs enemy.nav destination var to make patrolPoint
		}
	}


	/* //failed attempts to make patrol with an array and loops
	 void Update(){
		enemy.destination = patrolPoint [waypoint].position;

		foreach(Transform warp in patrolPoint){
			enemy.destination = patrolPoint[waypoint].transform.position; 
		}
		for(waypoint = 0; waypoint <= 0; waypoint++){
			enemy.destination = patrolPoint[waypoint].transform.position; 
			waypoint--;
		}
	}*/

}
