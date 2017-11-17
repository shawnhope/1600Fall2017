using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshRedMush : MonoBehaviour {

public Transform player;
public NavMeshAgent redMush;

	void Update(){
		redMush.destination = -player.position;
		}
}
