using UnityEngine;
using System.Collections;

public class FlickManager : MonoBehaviour {

	Vector3 pointBegin;
	Vector3 pointEnd;
	System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

	float minDist;
	float minSec = 0.3f;

	// Use this for initialization
	void Start () {
		minDist = 0.1f * (Screen.width+Screen.height);
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void OnFlick(Vector3 direction){
		Debug.Log ("Flick! " + direction);
	}

	public void OnBeginDrag(){
		pointBegin = Input.mousePosition;
		sw.Reset ();
		sw.Start ();
	}

	public void OnEndDrag(){
		sw.Stop ();
		pointEnd = Input.mousePosition;

		if (sw.Elapsed.TotalSeconds < minSec && Vector3.Distance (pointBegin, pointEnd) > minDist) {
			OnFlick (pointEnd - pointBegin);
		}
	}
}
