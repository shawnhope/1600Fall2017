using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers : MonoBehaviour {
	public GameObject player;
	public bool twranched = true;
	public enum PowerType{
		RedMush,
		HPDown,
	}
	//plug in for powerObj
	public PowerType power;

	void OnTriggerEnter(){
		switch (power) {
		case PowerType.HPDown:
			StartCoroutine (HPDown());
			break;
		}
	}

	IEnumerator HPDown (){
		//check see if twranched
		if(twranched == true){
			//if twranched, restart position at levelstart or checkpoint, lose life
			print("is already twranched");
		}
		else if (twranched == false){
			print ("is not twranced yet");
		//if not twranched, twranch, makewait before can hit again?
			player.transform.localScale += new Vector3 (0, -.4f);
			twranched = true;
			yield return new WaitForFixedUpdate ();
		}
	}
}
