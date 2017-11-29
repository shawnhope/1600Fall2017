using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedMushMove : MonoBehaviour {

public Vector3 mushMove;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		mushMove.x = 3*Time.deltaTime;
		transform.position = mushMove;
	}
}
