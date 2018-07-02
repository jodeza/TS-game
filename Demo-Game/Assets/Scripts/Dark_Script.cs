using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dark_Script : MonoBehaviour {

	public GameObject Shade;
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("Yellow") == 1) {
			Shade.SetActive (false);
		}else{
			Shade.SetActive (true);
		}
	}
}
