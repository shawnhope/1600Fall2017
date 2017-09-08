using UnityEngine;

public class Vars : MonoBehaviour {

	public float health = 100;

	void Start () {
		print("I'm gonna pre");
		health = 200;		
	}
	void OnTriggerEnter()
	{
		health += 20;	
	}
}