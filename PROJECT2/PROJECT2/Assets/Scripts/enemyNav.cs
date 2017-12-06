using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyNav : MonoBehaviour {

	public static Transform destination;
	public Transform firstdestination;
	public NavMeshAgent agent;

	void Start(){
		destination = firstdestination;  //sets transform to obj
	}
		
	void Update () {
		agent.destination = destination.position;  //agent's destination changes to destination transform
	}
}
