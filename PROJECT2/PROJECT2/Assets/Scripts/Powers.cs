using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers : MonoBehaviour {
	public GameObject player;
	public static bool twranched = false;
	public enum PowerType{
		RedMush,
		HPDown,
	}
	//plug in for powerObj
	public PowerType power;

	void OnTriggerEnter(){
		switch (power) {
		case PowerType.RedMush:
			StartCoroutine(RedMush());
			break;
		case PowerType.HPDown:
			StartCoroutine (HPDown());
			break;
		}
	}

	IEnumerator RedMush(){
		if (twranched == false){
			//do something or just add coin points
		}
		else if (twranched ==true){
			player.transform.localScale += new Vector3 (0, .4f);
			twranched = false;
		}
		Destroy(gameObject);
		yield return new WaitForFixedUpdate ();
	}
	IEnumerator HPDown (){
		//check see if twranched
		if(twranched == true){
			//if twranched, restart position at levelstart or checkpoint, lose life
		}
		else if (twranched == false){
		//if not twranched, twranch, makewait before can hit again?
			player.transform.localScale += new Vector3 (0, -.4f);
			twranched = true;
		}	
		yield return new WaitForFixedUpdate ();
		
	}
}
