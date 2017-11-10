using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

public Transform start;
public Transform end;
public LineRenderer line;


	void Update()
	{
		line.SetPosition(0, start.position);
		line.SetPosition(1, end.position);	
	}
}
