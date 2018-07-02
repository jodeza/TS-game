using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission_script : MonoBehaviour {

	public GameObject Achievement;

	void Update () {
		if (PlayerPrefs.GetInt("Tap") == 0) {
			if (Input.touchCount >= 1) {
				Achievement.SetActive(true);
				PlayerPrefs.SetInt ("Tap", 1);
				StartCoroutine(Delay());
			}
		}
	}

	IEnumerator Delay(){
		yield return new WaitForSeconds(1f); 
		Achievement.SetActive (false);
	}

}