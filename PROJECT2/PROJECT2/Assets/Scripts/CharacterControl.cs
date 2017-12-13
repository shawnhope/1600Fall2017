using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {

	public CharacterController characterControl;
	public float speed = 20f, gravity = 9.81f, jumpForce = 60f;
	public static Vector3 moveVector3;
	public static bool gameOver;
	public static bool youWon;

	void Update () {
		if (gameOver || youWon) {
			moveVector3.x = 0f;
		}
		if (!characterControl.isGrounded) {
			//when not grounded, V3.y = (downward)gravity
			moveVector3.y -= gravity * Time.deltaTime;
		}
		if (characterControl.isGrounded && !gameOver && !youWon) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				moveVector3.y = jumpForce * Time.deltaTime;
			}
			moveVector3.x = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
		} 
		characterControl.Move (moveVector3);
	}
}
