using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flag_Script : MonoBehaviour {

	public int level;

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.CompareTag ("Player")) {
			SceneManager.LoadScene ("Main_Scene");
			if (PlayerPrefs.GetInt ("Level") < level + 1) {
				PlayerPrefs.SetInt ("Level", level + 1);
			}
		}
	}

}