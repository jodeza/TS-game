using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour {
	public GameObject GameOver;

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.CompareTag ("Player")) {
			Destroy (coll.gameObject, 0f);
			GameOver.SetActive (true);
		}
	}

}