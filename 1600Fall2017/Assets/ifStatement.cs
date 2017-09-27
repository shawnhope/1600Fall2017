using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ifStatement : MonoBehaviour {

<<<<<<< HEAD
public Text input;
public bool canPlayGame = false;
public string password = "dank";

void Update(){
	if(input.text == password){
		print("YOo youre right i guess");
		canPlayGame = true;
		}
		else{
			print("invaild password, maybe you should've wrote it down");
		}

		if(canPlayGame){
			print("Playing game.");
		}
		else{
			print("Can't play yet, Enter correct password");
		}

	}	

=======
	public Text input;

	public bool canPlayGame = false;
	public string password = "G@am3Pl@y";

	void Update () {
		if(input.text == password) {
			print("You know the password.");
			canPlayGame = true;
		} else {
			print("The password is incorrect.");
		}

		if(canPlayGame) {
			print("Playing Game");
		}	else {
			print("Can't Play Yet, Enter a Correct Password.");
		}
	}
>>>>>>> character3
}
