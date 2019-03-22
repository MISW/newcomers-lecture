using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;	//ThirdPersonCharacterスクリプトを取得するために宣言

public class Player : MonoBehaviour {

	Animator anim;
	public GameObject timer;
	public GameObject panelGameover;
	public GameObject panelClear;
	ThirdPersonCharacter characterScr;
	bool isClear = false;
	bool isGameover = false;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();	
		panelGameover.SetActive (false);
		panelClear.SetActive (false);
		characterScr = GetComponent<ThirdPersonCharacter> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision coll){
		if (coll.transform.tag == "Enemy" && !isClear) {
			//敵に触れるとゲームオーバー
			Debug.Log("Game Over");
			GameOver();
		}
	}

	public void Clear(){
		if (!isGameover) {	//ゲームオーバーとクリアが同時に発生するバグを解消
			isClear = true;
			timer.SendMessage ("StopTimer");	//タイマーを止める
			characterScr.enabled = false;	//クリア時にプレイヤーの操作による移動を無効化
			panelClear.SetActive (true);	//クリア時のパネルを表示
		}
	}

	public void GameOver(){
		if (!isClear) {		//ゲームオーバーとクリアが同時に発生するバグを解消
			isGameover = true;
			anim.SetBool ("isGameover", true);
				//Animatorで新たなState及び変数を用意しておいた. ゲームオーバー時にしゃがむように設定
			timer.SendMessage ("StopTimer");	//タイマーを止める
			panelGameover.SetActive (true);	//ゲームオーバー時のパネルを表示
		}
	}
}
