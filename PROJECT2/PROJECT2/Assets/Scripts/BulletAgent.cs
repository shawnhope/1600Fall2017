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
		billAgent.destination = target.position;
		if (CharacterControl.gameOver == true) {
			bill.transform.position = spawn.transform.position;
		} 
	}
	void OnTriggerEnter(Collider other){
		if (other.isTrigger == true) {
				bill.transform.position = spawn.transform.position;
		}
	}
}

