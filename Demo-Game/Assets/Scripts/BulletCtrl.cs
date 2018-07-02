using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour {

	public Vector2 speed;
	public float delay;

	Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = speed;
		Destroy (gameObject, delay);
	}

	void Update () {
		rb.velocity = speed;
	}

	void OnCollisionEnter2D(Collision2D coll){
		Debug.Log ("Check");
		Destroy (gameObject, 0f);
	}
}
