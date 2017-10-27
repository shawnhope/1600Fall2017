using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {

	//Vector3 is a coordinate in space.
	public Vector3 moveVector3;
	//opens variable for CharacterController magic
	public CharacterController characterController;
	public float gravity = 9.81f, jumpForce = 50f, speed = 10f;

	void Update () {
		//the y coordinate moves in the negative(-=) 'down' direction *gravity var.
		moveVector3.y -= gravity * Time.deltaTime;
		if (characterController.isGrounded) {
			//ifGrounded turns gravity off, might lead to PROBLEMS LATER, but the v3.y always counting down drove me nuts.
			gravity = 0f;
			if (Input.GetKeyDown (KeyCode.Space)) {
				//ifGrounded && space is PRESSED, y coordinate == jumpForce var.
				moveVector3.y = jumpForce * Time.deltaTime;
			}
			//ifGrounded x/y coordinates move in 'horizontal/vertical' directions *speed var.
			moveVector3.x = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
			moveVector3.z = Input.GetAxis ("Vertical") * speed * Time.deltaTime;
		} else {
			//turns gravity back on while notGrounded
			gravity = 9.81f;
		}
		//tells the CC to MOVE(what it's attached to) with the V3's coordinates.
		characterController.Move (moveVector3);
	}
}
