using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Powers : MonoBehaviour {

	public int totalCoinValue, coinValue = 1;
	public Text coinNum;
	public GameObject player, GameOverUI;
	public static bool twranched = false;
	public enum PowerType{
		RedMush,
		HPDown,
		Coin,
		InstaDeath
	}

	public PowerType power;					//plug in for powerObj

	void OnTriggerEnter(Collider other){

		if(other.isTrigger == false){	
			switch (power) {				//looks for which power is selected
			case PowerType.RedMush:
				StartCoroutine (RedMush ());
				break;
			case PowerType.HPDown:
				StartCoroutine (HPDown ());
				break;
			case PowerType.Coin:
				StartCoroutine (Coin ());
				break;
			case PowerType.InstaDeath:
				StartCoroutine (InstaDeath ());
				break;
			}
		}
	}

	IEnumerator RedMush(){					//if RedMush is selected:
		if (twranched == false){
//>>>>>>ADD == destroy trigger? change powerup or just add coin points && change color of block
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
//>>>>>>>ADD == if twranched, restart position at levelstart or checkpoint, lose life
			GameOverUI.SetActive(true);
			CharacterControl.gameOver = true;
		}
		else if (twranched == false){		//if not twranched, twranch and changes state
//>>>>>>>ADD == find way to make it wait before it can hit again so no immediate death on contact
			player.transform.localScale += new Vector3 (0, -.2f);
			yield return new WaitForSeconds(.5f);  //bug: probability of killing enemy before twranch can change to true
			twranched = true;
		}	
		yield return new WaitForFixedUpdate ();
	}
	IEnumerator Coin (){
		totalCoinValue = int.Parse(coinNum.text); 			//converts UI totalText into numbers for totalCoins var
	 	int tempAmount = totalCoinValue + coinValue; 		//stores data for sum of totalCoins+coinGet in var
	 	while(totalCoinValue <= tempAmount){ 				//while totalCoins is less/equal storageVar,
		 	coinNum.text = (totalCoinValue++).ToString(); 	//UI totalText visually changes by one upwards til total equals storageVar
		 	yield return new WaitForFixedUpdate(); 
		 }
	}
	IEnumerator InstaDeath(){
		GameOverUI.SetActive (true);
		CharacterControl.gameOver = true;
		yield return new WaitForFixedUpdate ();
	}
}
