using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour {

	public int numItems;	//クリアに必要なアイテムの個数
	public GameObject itemPrefab;
	public GameObject[] markers = new GameObject[4];	//アイテムの設置の基準点
	public GameObject head;	//プレイヤーの頭上の基準点
	int num = 0;	//現在設置済みのアイテム数

	public GameObject player;

	// Use this for initialization
	void Start () {
		//一つ目のアイテムを設置
		SetItem ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetItem(){
		//アイテムを一定数ゴールへ届けるとクリアー
		if (num < numItems) {
			//ランダムで設置箇所を決める
			int rand = (int)(Random.value * 100) % 4;
			Debug.Log ("rand = " + rand);
			//プレハブのインスタンス化,位置と回転を指定する
			GameObject item = Instantiate (itemPrefab,markers [rand].transform.position,transform.rotation) as GameObject;
			//アイテムの変数にオブジェクトを代入する処理の呼び出し
			item.SendMessage ("SetManager",gameObject);
			item.SendMessage ("SetHead",head);
			//作成したアイテムの個数をカウント
			num++;
		} else {
			//クリアー時の処理を呼び出し
			Debug.Log("Clear!");
			player.SendMessage ("Clear");
		}
	}
}
