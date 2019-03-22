using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.C)) {
			Debug.Log ("DebugKey : ALL CLEAR");
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter(Collision coll){
		if (coll.transform.tag == "Ball") {
			Destroy (gameObject);
		}
	}
}
