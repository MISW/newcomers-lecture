using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	Rigidbody rigid;
	float minVel = 3;
	Vector3 vel;
	public GameObject panelPause;
	public GameObject panelGameOver;

	// Use this for initialization
	void Start () {
		rigid = gameObject.GetComponent<Rigidbody> ();
		rigid.AddForce (1,4,0,ForceMode.VelocityChange);
		vel = rigid.velocity;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) && !panelPause.activeSelf) {
			SetMoving (false);
			panelPause.SetActive (true);
		}
	}

	void OnCollisionEnter(Collision coll){
		if (coll.transform.tag == "EndLine") {
			Debug.Log ("GameOver");
			SetMoving (false);
			panelGameOver.SetActive (true);
		}else if (coll.transform.tag == "Player") {
			if (rigid.velocity.x < minVel && rigid.velocity.x > -minVel) {
				rigid.AddForce (minVel, 0, 0, ForceMode.VelocityChange);
			}
		}

		if (rigid.velocity.y < minVel && rigid.velocity.y > -minVel) {
			rigid.AddForce (0, minVel, 0, ForceMode.VelocityChange);
		}
	}

	public void SetMoving(bool arg){
		if (arg) {
			rigid.isKinematic = false;
			rigid.velocity = vel;
		} else {
			vel = rigid.velocity;
			rigid.isKinematic = true;
		}
	}
		
}
