using UnityEngine;
using System.Collections;
using UnityEngine.UI;    //Textクラスを扱うために使用

//テキストを点滅させる
public class BlinkText : MonoBehaviour {

	Text text;
    float n;    //各フレームの変化量
	float speedMul = 0.5f;	//変化の速度を調節
	Color color1;

    // Use this for initialization
	void Start () {
		text = GetComponent<Text>();
		color1 = text.color;	//初期値を取得
	}
    
	// Update is called once per frame
   void Update () {

		n = speedMul * Time.deltaTime;
		color1.a += n;	//不透明度を増減
		text.color = color1;
			//コンポーネントの持つcolorはColor型単位でしか変更できない.
			//text.color.a += n; //とするとエラー

		//変化量の正負を反転,明滅させる
		if (color1.a < 2 * n) {
			speedMul = 0.5f;
		} else if(color1.a > 1-2*n){
			speedMul = -0.5f;
		}    
	}
} 
