using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Button_Events2 : MonoBehaviour {

	public GameObject PauseCanvas;
	public GameObject MainCanvas;

	public void Pause(){
		Time.timeScale = 0;
		PauseCanvas.SetActive(true);
	}

	public void Resume(){
		Time.timeScale = 1;
		PauseCanvas.SetActive (false);
	}

	public void TryAgain(){
		Time.timeScale = 1;
		SceneManager.LoadScene ("Main_Scene");
	}

}