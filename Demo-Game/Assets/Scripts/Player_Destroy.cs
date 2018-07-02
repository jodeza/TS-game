using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Destroy : MonoBehaviour {

	public GameObject GameOver;

	void OnTriggerEnter2D(Collider2D coll){
		if(coll.gameObject.CompareTag("Player")){
			Destroy (coll.gameObject, 0f);
			GameOver.SetActive (true);
		}
	}
}
