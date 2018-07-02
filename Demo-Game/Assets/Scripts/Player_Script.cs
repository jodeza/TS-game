using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Script : MonoBehaviour {

	public float speed;
	public float jump;
	public GameObject Model;
	public Text infoText;
	public GameObject GroundChecker;
	public GameObject FirePos,FirePos2;
	public GameObject LBullet, RBullet;

	public bool isFacingRight = true;
	public bool red, blue, green, yellow;
	public string[] info;
	private int PlayerColor;
	GroundChecker groundChecker;
	private int Rmove, Lmove;

	void Start(){
		red = true;
		blue = false;
		green = false;
		yellow = false;
		PlayerColor = 1;
		infoText.text = info [0];
		groundChecker = GroundChecker.GetComponent<GroundChecker>();
		PlayerPrefs.SetInt ("Yellow", 0);
	}

	
	void Update () {
		if (blue == true) {
			groundChecker.jump = 60;
		} else {
			groundChecker.jump = 40;
		}
		if (Input.GetKeyDown (KeyCode.A) || Input.GetKey (KeyCode.A)) {
			transform.position += Vector3.left * speed * Time.deltaTime;
			gameObject.GetComponent<Animator> ().SetBool ("isMoving", true);
			gameObject.GetComponent<SpriteRenderer> ().flipX = true;
			isFacingRight = false;
			FirePos.SetActive (false);
			FirePos2.SetActive (true);
		}
		if (Input.GetKeyDown (KeyCode.D) || Input.GetKey(KeyCode.D)) {
			transform.position += Vector3.right * speed * Time.deltaTime;
			gameObject.GetComponent<Animator>().SetBool ("isMoving", true);
			gameObject.GetComponent<SpriteRenderer> ().flipX = false;
			isFacingRight = true;
			FirePos2.SetActive (false);
			FirePos.SetActive (true);
		}
		if(Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)){
			gameObject.GetComponent<Animator>().SetBool ("isMoving", false);
		}

		if (Rmove == 1) {
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Lmove == 1) {
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
	}

	public void Btn_Next(){
		if (red == true) {
			blue = true;
			red = false;
			gameObject.GetComponent<SpriteRenderer> ().color = new Color(0.262f,0.376f,0.960f,1);
			Model.GetComponent<Image> ().color = new Color(0.262f,0.376f,0.960f,1);
			infoText.text = info [1];
			PlayerPrefs.SetInt ("Yellow", 0);
		}else if (blue == true) {
			green = true;
			blue = false;
			gameObject.GetComponent<SpriteRenderer> ().color = new Color (0f, 1f, 0f, 1f);
			Model.GetComponent<Image> ().color = new Color(0f, 1f, 0f, 1f);
			infoText.text = info [2];
			PlayerPrefs.SetInt ("Yellow", 0);
		}else if (green == true) {
			yellow = true;
			green = false;
			gameObject.GetComponent<SpriteRenderer> ().color = new Color(1f, 1f, 0f, 1f);
			Model.GetComponent<Image> ().color = new Color(1f, 1f, 0f, 1f);
			PlayerPrefs.SetInt ("Yellow", 1);
			infoText.text = info [3];
		}else if (yellow == true) {
			red = true;
			yellow = false;
			gameObject.GetComponent<SpriteRenderer> ().color = new Color(1f, 0f, 0f, 1f);
			Model.GetComponent<Image> ().color = new Color(1f, 0f, 0f, 1f);
			infoText.text = info [0];
			PlayerPrefs.SetInt ("Yellow", 0);
		}
	}

	public void Btn_Prev(){
		if (blue == true) {
			red = true;
			blue = false;
			gameObject.GetComponent<SpriteRenderer> ().color = new Color(1f, 0f, 0f, 1f);
			Model.GetComponent<Image> ().color = new Color(1f, 0f, 0f, 1f);
			infoText.text = info [0];
			PlayerPrefs.SetInt ("Yellow", 0);
		}else if (green == true) {
			blue = true;
			green = false;
			gameObject.GetComponent<SpriteRenderer> ().color = new Color(0.262f,0.376f,0.960f,1);
			Model.GetComponent<Image> ().color = new Color(0.262f,0.376f,0.960f,1);
			infoText.text = info [1];
			PlayerPrefs.SetInt ("Yellow", 0);
		}else if (yellow == true) {
			green = true;
			yellow = false;
			gameObject.GetComponent<SpriteRenderer> ().color = new Color (0f, 1f, 0f, 1f);
			Model.GetComponent<Image> ().color = new Color(0f, 1f, 0f, 1f);
			infoText.text = info [2];
			PlayerPrefs.SetInt ("Yellow", 0);
		}else if (red == true) {
			yellow = true;
			red = false;
			gameObject.GetComponent<SpriteRenderer> ().color = new Color(1f, 1f, 0f, 1f);
			Model.GetComponent<Image> ().color = new Color(1f, 1f, 0f, 1f);
			infoText.text = info [3];
			PlayerPrefs.SetInt ("Yellow", 1);
		}
	}

	public void btn_Shoot(){
		if (red == true) {
			if (isFacingRight == false) {
				Instantiate (LBullet, FirePos2.transform.position, Quaternion.identity);
			}
			if (isFacingRight == true) {
				Instantiate (RBullet, FirePos.transform.position, Quaternion.identity);
			}
		}
	}

	public void btn_Left(){
		Lmove = 1;
		gameObject.GetComponent<Animator> ().SetBool ("isMoving", true);
		gameObject.GetComponent<SpriteRenderer> ().flipX = true;
		isFacingRight = false;
		FirePos.SetActive (false);
		FirePos2.SetActive (true);
	}

	public void btn_Right(){
		Rmove = 1;
		gameObject.GetComponent<Animator>().SetBool ("isMoving", true);
		gameObject.GetComponent<SpriteRenderer> ().flipX = false;
		isFacingRight = true;
		FirePos2.SetActive (false);
	}

	public void btn_Release(){
		Rmove = 0;
		Lmove = 0;
		gameObject.GetComponent<Animator>().SetBool ("isMoving", false);
	}
		
}
