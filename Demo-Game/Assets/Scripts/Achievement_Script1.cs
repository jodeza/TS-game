using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievement_Script1 : MonoBehaviour {

	public GameObject Jump;

	private int clear=0;

	void Update () {
		if (clear == 1) {
			Jump.SetActive (true);
			StartCoroutine (Delay ());
		}
	}

	IEnumerator Delay(){
		clear = 2;
		yield return new WaitForSeconds (2f);
		Jump.SetActive (false);
	}

	public void btn_clear(){
		if (clear != 2) {
			clear = 1;
		}
	}
}
