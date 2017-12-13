using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BulletAgent : MonoBehaviour {

	public NavMeshAgent billAgent;
	public Transform target, spawn;
	public GameObject bill;


	void Update ()
	{
		billAgent.destination = target.position;   //makes bullet destination the target's position
		if (CharacterControl.gameOver == true) { 	//if gameover is true, bullet goes back to spawn point, wish i'dve done that with everything else
			bill.transform.position = spawn.transform.position;
		} 
	}
	void OnTriggerEnter(Collider other){
		if (other.isTrigger == true) {		//if ontrigger, target is hit with something else with a trigger(bullet), bullet goes to spawn point
			bill.transform.position = spawn.transform.position;
		}
	}
}

