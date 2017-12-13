using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBill : MonoBehaviour {

	public GameObject Bill, player;
	public Transform spawn;
	public float speed = 5f;
	public Vector3 billV3;

	void OnTriggerStay(){
		FixedUpdate ();
	}
	void FixedUpdate(){
		GameObject tempBill;
		tempBill = Instantiate (Bill, spawn.transform.position, spawn.transform.rotation);
		tempBill.transform.Rotate(Vector3.forward*90);
		//weird putting rb call here.. but wouldn't work under gO hmm
		Rigidbody rigBill;
		rigBill = tempBill.GetComponent<Rigidbody> ();
		rigBill.transform.position = Vector3.MoveTowards(transform.position, player.transform.localPosition, speed*Time.deltaTime);
		Destroy (tempBill, 2f);
	}
}
