using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

public float speed = 3f;
public float height = 4f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.D))
		transform.position += transform.right * Time.deltaTime * height;
			//transform.Translate(speed * Time.deltaTime, 0, 0);
		else if(Input.GetKey(KeyCode.A))
		transform.position -= transform.right * Time.deltaTime * height;
			//transform.Translate(-speed * Time.deltaTime, 0, 0);
		else if(Input.GetKey(KeyCode.W))
			transform.position += transform.forward * Time.deltaTime * height;
		//transform.Translate(0,height * Time.deltaTime, 0);
		else if(Input.GetKey(KeyCode.S))
		transform.position -= transform.forward * Time.deltaTime * height;
			//transform.Translate(0, -height * Time.deltaTime, 0);
	}
}
