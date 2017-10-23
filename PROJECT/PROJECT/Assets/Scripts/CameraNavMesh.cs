using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//dont forget~  ..also set angular speed to 0
using UnityEngine.AI;

public class CameraNavMesh : MonoBehaviour {
	
	public Transform player;
	public NavMeshAgent agent;

	void Start(){
	}
	void Update () {
		//agent's destination is the player's current position
		agent.destination = player.position;
	}
}
