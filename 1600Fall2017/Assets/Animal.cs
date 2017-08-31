using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

	// Use this for initialization
	public virtual void Start () {
			Die();
			Eat();
			Sleep();
	}
		/*this is a comment for an assignment
		this is a second line of a comment */
	void Die () {
		print(this.name + " Died");
	}	
	void Eat () {
		print(this.name + " Eats");
	}
	void Sleep () {
		print(this.name + " Sleeps");
	}
		
	}

