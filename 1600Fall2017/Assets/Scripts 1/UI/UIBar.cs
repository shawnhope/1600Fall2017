using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UI
using UnityEngine.UI;

public class UIBar : MonoBehaviour {

public Image bar;
public float barTime = 0.1f;

	void OnTriggerEnter(){
		//starts the coroutine
		StartCoroutine(UpdateBar());
	}
	
	//a coroutine..ok?
	IEnumerator UpdateBar (){
		while(bar.fillAmount < 1){
			bar.fillAmount += barTime;
			//takes one barTime then waits second
			yield return new WaitForSeconds(barTime);
		}
	}
}
