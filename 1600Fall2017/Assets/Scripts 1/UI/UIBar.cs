using System.Collections;
using UnityEngine;
//using UI
using UnityEngine.UI;

public class UIBar : MonoBehaviour {

//Image is found in .UI
public Image bar;
public float barTime = 0.1f;
public float powerLevel = 0.1f;
public float amountToAdd = 0.1f;

public enum PowerUpType{
	PowerUp, 
	PowerDown
}
public PowerUpType powerUp;

	void OnTriggerEnter(){
		
		switch(powerUp){
			case PowerUpType.PowerUp:
				//starts the coroutine
				StartCoroutine(PowerUpBar());
			break;
				case PowerUpType.PowerDown:
				StartCoroutine(PowerDownBar());
			break;
		}
	}
	
	//a coroutine..ok? (lets you repeat something) has to yield to cycle through. it stops once its true
	IEnumerator PowerUpBar ()
	{
		while(bar.fillAmount < 1)
		{
			bar.fillAmount += amountToAdd;

			//takes one barTime then waits second
			yield return new WaitForSeconds(barTime);
		}
	}

	IEnumerator PowerDownBar()
	{
		float tempAmount = powerLevel;
		float fillAmount = bar.fillAmount;
		while (tempAmount > 0)
		{
			bar.fillAmount = tempAmount - amountToAdd;
			bar.fillAmount = fillAmount;
			
			yield return new WaitForSeconds(barTime);
		}
	}
}