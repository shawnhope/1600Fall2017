using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRot : MonoBehaviour {

	public GameObject camTarget;
	public float rotSpeed = 150f;
	public Vector3 camTargetRot;

	void Update () {
		camTargetRot.y += Input.GetAxis ("Mouse X") * rotSpeed * Time.deltaTime;
		camTargetRot.x -= Input.GetAxis ("Mouse Y") * rotSpeed * Time.deltaTime;
		camTarget.transform.eulerAngles = camTargetRot;
		//to make delay/lagged cam, have it 'chase' player and a little slower speed than player?
	}
}
