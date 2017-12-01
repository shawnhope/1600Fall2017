using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {

	public CharacterController characterControl;
	public float speed = 15f, gravity = 9.81f, jumpForce = 50f;
	public static Vector3 moveVector3;

	void Update () {
		if (!characterControl.isGrounded) {
			//when not grounded, V3.y = (downward)gravity
			moveVector3.y -= gravity * Time.deltaTime;
		}
		if (characterControl.isGrounded) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				moveVector3.y = jumpForce * Time.deltaTime;
			}
			moveVector3.x = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
		} 
		characterControl.Move (moveVector3);
	}
}
