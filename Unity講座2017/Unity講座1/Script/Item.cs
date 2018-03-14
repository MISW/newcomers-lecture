using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

	bool onGoal = false;	//ゴールに入ったか否か
	bool onPlayer = false;	//プレイヤーに持たれているか
	Rigidbody rigid;
	GameObject itemManager;
	GameObject head;
	Collider collItem;	//アイテム自身のコライダー

	// Use this for initialization
	void Start () {
		//自身の持つコンポーネントから指定の種類のものを取得
		rigid = gameObject.GetComponent<Rigidbody> ();
		collItem = GetComponent<Collider> ();
	}
	
	// Update is called once per frame
	void Update () {
		//アイテムを投げる
		if( Input.GetKeyDown(KeyCode.LeftShift) && onPlayer){
			Debug.Log ("Shoot Item");
			collItem.isTrigger = false;	//コライダーの特性を切替
			onPlayer = false;
			gameObject.transform.SetParent (null);	//headを親から外してプレイヤーの移動と切り離す
			rigid.isKinematic = false;	//物理法則を有効化
			rigid.AddForce (4.0f * transform.forward, ForceMode.VelocityChange);	//アイテムに,前方に向かう力を加える
		}
	}

	void OnCollisionEnter(Collision coll){
		//衝突した相手のタグを見て処理を場合分け
		if (coll.transform.tag == "Player" && !onGoal) {	//プレイヤーに触れて,ゴール済みではない場合
			Debug.Log ("Get Item");
			onPlayer = true;
			collItem.isTrigger = true;
			rigid.isKinematic = true;	//物理法則を無効化
			gameObject.transform.SetParent (head.transform);	//headを親にすることでプレイヤーの移動に追従させる
			gameObject.transform.localPosition = Vector3.zero;	//ローカル座標(親から見た位置)を(0,0,0)にすることで親の位置に移動
			gameObject.transform.localRotation = Quaternion.Euler(0,0,0);
		}
			
		if (coll.transform.tag == "Goal") {	//ゴールに触れると
			rigid.isKinematic = true;
			onGoal = true;
			itemManager.SendMessage ("SetItem");
		}
			
	}

	//インスタンス化したItemに、itemManagerとheadを紐付けるための関数.
	public void SetManager(GameObject obj){
		itemManager = obj;
	}
	public void SetHead(GameObject obj){
		head = obj;
	}

}
