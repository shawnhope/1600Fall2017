using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour {

	public GameObject Enemy, RedMush;
	public Transform spawnpoint;
	public enum CollisionThing{
		Block,
		Stomp,
	}
	public CollisionThing colThing;

	void  OnTriggerEnter(){
		switch (colThing){
		case CollisionThing.Block:
			Instantiate (RedMush, spawnpoint.position, spawnpoint.rotation);
			break;
		case CollisionThing.Stomp:
			GameObject.Destroy (Enemy);
			CharacterControl.moveVector3.y = 50 * Time.deltaTime;
			Powers.expended = true;
			break;
		}
	}
}
