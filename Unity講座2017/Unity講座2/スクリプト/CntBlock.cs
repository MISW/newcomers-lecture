using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CntBlock : MonoBehaviour {

	bool isClear = false;
	public GameObject ball;
	public GameObject panelClear;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!isClear && transform.childCount == 0 ) {
			isClear = true;
			ball.SendMessage ("SetMoving", false);
			//テキストを表示
			panelClear.SetActive (true);
			Debug.Log ("Clear!");
		}

		//ゲーム終了の処理
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
			
	}
}
