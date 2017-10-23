using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshAI : MonoBehaviour {

//make sure player is on player layer, level on level layer.
//make plane for camera, add navmeshagent to camera, then bake the camPlane for camera to follow

//gets location of public player variable
public Transform player;
//put camera in agent public variable, its the agent
public NavMeshAgent agent;

	void Update () {
		//agent(cam)'s destination becomes the player's position
		agent.destination = player.position;
	}
}
