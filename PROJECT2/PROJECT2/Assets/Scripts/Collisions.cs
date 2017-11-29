using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour {

public GameObject RedMush;
public Transform spawnpoint;
public enum CollisionThing{
	Block
}
public CollisionThing colThing;

	void  OnTriggerEnter()
	{
		switch(colThing){
			case CollisionThing.Block:
			Instantiate(RedMush, spawnpoint.position, spawnpoint.rotation);
			break;
		}
	}
}
