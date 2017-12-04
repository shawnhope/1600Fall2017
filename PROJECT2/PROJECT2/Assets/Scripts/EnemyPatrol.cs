using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyPatrol : MonoBehaviour {

public Transform patrolPoint;
	void OnTriggerEnter(){
	enemyNav.destination = patrolPoint;  //grabs enemy.nav destination var to make patrolPoint
	}


	/*void Update(){
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
