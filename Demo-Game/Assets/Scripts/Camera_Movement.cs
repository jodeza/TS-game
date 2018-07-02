using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour {
	public int speed = 2;
	
	void Update () {
		transform.position += Vector3.right*Time.deltaTime*speed;
	}

}
