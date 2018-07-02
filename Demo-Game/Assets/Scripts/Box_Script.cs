using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_Script : MonoBehaviour {
	
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.CompareTag ("Bullet")) {
			Destroy (gameObject, 0f);
		}
	}
}