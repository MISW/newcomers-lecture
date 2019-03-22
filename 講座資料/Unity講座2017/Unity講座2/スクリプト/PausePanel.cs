using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePanel : MonoBehaviour {

	public GameObject ball;

	// Use this for initialization
	void Start () {
		//gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			ball.SendMessage ("SetMoving", true);
			gameObject.SetActive (false);
		}
	}
}
