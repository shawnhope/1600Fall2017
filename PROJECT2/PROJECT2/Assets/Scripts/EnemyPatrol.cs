using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyPatrol : MonoBehaviour {

public GameObject[] points;
public NavMeshAgent enemy;
public Transform patrolPoint;

void Start(){
	//need to find a way to make the transform the array :/
	patrolPoint = points;
}
void Update()
{
	foreach(GameObject GameObject in points){
	enemy.destination = patrolPoint.position; 
	}
}

}
