using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour {

	public bool isGrounded;
	public GameObject Player;
	public float jump;

	void Update () {
		if (Input.GetKeyDown (KeyCode.W)) {
			if (isGrounded == true) {
				Player.GetComponent<Animator>().SetBool ("isJumping", true);
				Player.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, jump), ForceMode2D.Impulse);
			}
		}
		
	}

	public void btn_Jump(){
		if (isGrounded == true) {
			Player.GetComponent<Animator>().SetBool ("isJumping", true);
			Player.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, jump), ForceMode2D.Impulse);
		}
	}
		
	void OnCollisionEnter2D(Collision2D coll){
		if (!coll.gameObject.CompareTag ("Player")) {
			isGrounded = true;
			Player.GetComponent<Animator>().SetBool ("isJumping", false);
		}
	}

	void OnCollisionExit2D(Collision2D coll){
		if (!coll.gameObject.CompareTag ("Player")) {
			isGrounded =false;
		}
	}
}
