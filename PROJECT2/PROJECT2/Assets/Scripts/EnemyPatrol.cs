using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyPatrol : MonoBehaviour {

public NavMeshAgent enemy;
public Transform[] patrolPoint;
	private int waypoint=0;

	void OnTriggerEnter(){
		if (waypoint == 0) {
			waypoint = 1;
		} 
		else if (waypoint == 1) {
			waypoint = 0;
		}
	}

	void Update (){
		enemy.destination = patrolPoint [waypoint].position;
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
