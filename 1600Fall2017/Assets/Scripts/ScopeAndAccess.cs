using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccess : MonoBehaviour {

	private int health = 100;

	public int score = 100;

	string thing1 ="Thing1";
	string thing2;

	void Box(){
		thing1 = "fun";
		thing2 = "Things it can't do.";
		print(thing2);
		
/*		void Box2(){
			string foxInBox = "Game is done";
			print(foxInBox);
			thing1 = "A lot of fun";
			print(thing1);
		
		Box2();
		}*/
		
	}
void NewBox(){
	thing1 = "New Thing";
	thing2 = "New Thing Too";
}


}
