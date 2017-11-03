using System.Collections;
using UnityEngine;
//using UI
using UnityEngine.UI;

public class UIBar : MonoBehaviour {

//Image is found in .UI
public Image bar;
public Text coinNum;
public int totalCoinValue;
public int coinValue = 10;
public GameObject gameOverUI;
public float powerLevel = 0.1f;
public float amountToAdd = 0.1f;

public enum PowerUpType{
	PowerUp, 
	PowerDown,
	CollectCoin
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
			case PowerUpType.CollectCoin:
				//start the coroutine "CollectCoin"
				StartCoroutine(CollectCoin());
			break;
		}
	}
	
IEnumerator CollectCoin (){

	totalCoinValue = int.Parse(coinNum.text);
	int tempAmount = totalCoinValue + coinValue;
	while(totalCoinValue <= tempAmount)
	{
		coinNum.text = (totalCoinValue++).ToString();
		yield return new WaitForFixedUpdate();
	}
}

	//a coroutine..ok? (lets you repeat something) has to yield to cycle through. it stops once its true
	IEnumerator PowerUpBar ()
	{
		float tempAmount = bar.fillAmount + powerLevel;
		if(tempAmount > 1)
		{
			tempAmount = 1;
		}
		while(bar.fillAmount < tempAmount)
		{
			bar.fillAmount += amountToAdd;

			//takes one barTime then waits second
			yield return new WaitForSeconds(amountToAdd);
		}
	}

	IEnumerator PowerDownBar ()
	{
		float tempAmount = bar.fillAmount - powerLevel;
		if(tempAmount < 0)
		{
			tempAmount = 0;
		}
		while(bar.fillAmount > tempAmount)
		{
			bar.fillAmount -= amountToAdd;

			//takes one barTime then waits second
			yield return new WaitForSeconds(amountToAdd);
		}
		
		if(bar.fillAmount == 0)
		{
			gameOverUI.SetActive(true);
			CharacterControl.gameOver = true;
		}
	}
}
