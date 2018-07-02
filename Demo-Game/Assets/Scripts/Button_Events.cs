using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button_Events : MonoBehaviour {
	public GameObject mainCanvas;
	public GameObject levelCanvas;
	public GameObject CreditsCanvas;
	public Button Btn2, Btn3, Btn4, Btn5;

	public void StartBtn(){
		mainCanvas.GetComponentInChildren<Animator>().SetBool ("isExit", true);
		StartCoroutine(MainExit());
		StopCoroutine (MainExit());
		if (PlayerPrefs.GetInt ("Level") >= 2) {
			Btn2.interactable = true;
		}
		if (PlayerPrefs.GetInt ("Level") >= 3) {
			Btn3.interactable = true;
		}
		if (PlayerPrefs.GetInt ("Level") >= 4) {
			Btn4.interactable = true;
		}
	}

	IEnumerator MainExit(){
		levelCanvas.SetActive(true);
		yield return new WaitForSeconds(1f); 
		mainCanvas.GetComponentInChildren<Animator>().SetBool ("isExit", false);
		mainCanvas.SetActive(false);
	}

	public void LevelExitBtn(){
		levelCanvas.GetComponentInChildren<Animator>().SetBool ("isExit", true);
		StartCoroutine(LevelExit());  
		StopCoroutine(LevelExit()); 
	}

	IEnumerator LevelExit(){
		mainCanvas.SetActive(true);
		yield return new WaitForSeconds(1f); 
		levelCanvas.GetComponentInChildren<Animator>().SetBool ("isExit", false);
		levelCanvas.SetActive(false);
	}

	public void btnLvl1(){
		SceneManager.LoadScene ("Level_1");
	}

	public void btnLvl2(){
		SceneManager.LoadScene ("Level_2");
	}

	public void btnLvl3(){
		SceneManager.LoadScene ("Level_3");
	}

	public void btnLvl4(){
		SceneManager.LoadScene ("Level_4");
	}

	public void btnExit(){
		Application.Quit ();
	}

	public void Credit(){
		CreditsCanvas.SetActive(true);
	}

	public void CreditExit(){
		CreditsCanvas.SetActive(false);
	}
}
