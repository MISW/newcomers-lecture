using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearText : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			//リスタート
			SceneManager.LoadScene (SceneManager.GetActiveScene().name);
		}
	}
}
