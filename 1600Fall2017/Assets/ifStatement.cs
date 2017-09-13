using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ifStatement : MonoBehaviour {

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

}
