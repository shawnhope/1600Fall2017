using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterControl : MonoBehaviour {

	public float gravity = 9.81f;
	public float speed = 10;
	public float jumpForce = 20;
	public CharacterController characterController;
	public Vector3 moveVector3;

	void FixedUpdate () {
		//stores v3 into variable; makes negative y direction (gravity) use realtime.
		moveVector3.y -= gravity * Time.deltaTime;

		//checks to see if gameObject is 'grounded'
		if (characterController.isGrounded) {
			if (Input.GetKey (KeyCode.Space)) {
				//if grounded && Space is pressed, makes positive y direction (jumpForce) in rt
				moveVector3.y += jumpForce * Time.deltaTime;
			}
			//if grounded while horizontal button presssed, move in either direction in rt
			moveVector3.x = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
		}
		//idk
		characterControl.Move(moveVector3);
	}
}
