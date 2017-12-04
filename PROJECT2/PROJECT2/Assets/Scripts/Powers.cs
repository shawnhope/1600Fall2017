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

	public PowerType power;					//plug in for powerObj

	void OnTriggerEnter(Collider _col){


		//////////////////////////////figure this OUT
		/// 
		/// 
		/// VVVV
		if(_col = player.GetComponent( )){	
			switch (power) {				//looks for which power is selected
			case PowerType.RedMush:
				StartCoroutine (RedMush ());
				break;
			case PowerType.HPDown:
				StartCoroutine (HPDown ());
				break;
			}
		}
	}

	IEnumerator RedMush(){					//if RedMush is selected:
		if (twranched == false){
			//ADD == destroy trigger? change powerup or just add coin points && change color of block
		}
		else if (twranched ==true){			//if little, stretches and changes state
			player.transform.localScale += new Vector3 (0, .4f);
			twranched = false;
		}
		Destroy(gameObject);				//one use
		yield return new WaitForFixedUpdate ();
	}
	IEnumerator HPDown (){					//if HPDown is selected:
		if(twranched == true){				//check see if twranched
			//ADD == if twranched, restart position at levelstart or checkpoint, lose life
		}
		else if (twranched == false){		//if not twranched, twranch and changes state
			//ADD == find way to make it wait before it can hit again so no immediate death on contact
			player.transform.localScale += new Vector3 (0, -.4f);
			twranched = true;
		}	
		yield return new WaitForFixedUpdate ();
		
	}
}
