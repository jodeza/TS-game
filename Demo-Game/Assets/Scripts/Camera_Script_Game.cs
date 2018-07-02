using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Script_Game : MonoBehaviour { 
	public Transform Player;

	void Update ()
	{
		transform.position = new Vector3(Player.transform.position.x, transform.position.y, transform.position.z);
	}
}
