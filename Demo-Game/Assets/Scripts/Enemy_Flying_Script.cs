using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Flying_Script : MonoBehaviour {

	public GameObject Model;
	public Vector2 speed;

	private int trigger=0;

	void Update () {
		if (trigger == 1) {
			Model.GetComponent<Rigidbody2D>().velocity = speed;
		}
	}

	void OnTriggerEnter2D(Collider2D coll){
		if(coll.gameObject.CompareTag("Player")){
			trigger = 1;
		}
	}
}