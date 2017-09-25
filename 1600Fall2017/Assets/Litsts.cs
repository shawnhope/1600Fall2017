using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Litsts : MonoBehaviour {
	public List<GameObject> myWeapons;

void onTriggerEnter(Collider _weapon)
{
	myWeapons.Add(_weapon.gameObject);
}


}
