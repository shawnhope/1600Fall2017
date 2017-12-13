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
			print ("mushrooming");
			break;
		case CollisionThing.Stomp:
			Enemy.SetActive (false);		//works
			//GameObject.Destroy (Enemy);  //was eh
			CharacterControl.moveVector3.y = 50 * Time.deltaTime;
			print ("stomping");
			break;
		}
	}
}
