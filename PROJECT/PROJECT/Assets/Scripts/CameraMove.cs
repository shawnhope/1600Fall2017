using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

	public Vector3 camVec3;
	public float speed = 20f;
	public CharacterController camControl;

	void Start () {
		
	}

	void Update () {
		camVec3.z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
		camControl.Move(camVec3);
	}
}
