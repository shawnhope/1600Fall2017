using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ifStatement : MonoBehaviour {

public Text input;
public string password = "dank";

void Update(){
	if(input.text == password){
		print("YOo youre right i guess");
		}
	}	

}
