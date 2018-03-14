using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
	public Text text1;

	// Use this for initialization
	void Start () {
		sw.Start ();
	}
	
	// Update is called once per frame
	void Update () {
		text1.text = "TIME  "+ (int)sw.Elapsed.TotalSeconds;
	}

	public void StopTimer(){	//一時停止
		sw.Stop ();
	}
	public void StartTimer(){	//計測開始
		sw.Start ();
	}
	public void ResetTimer(){	//リセット
		sw.Reset ();
	}

}
