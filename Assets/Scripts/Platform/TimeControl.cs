using UnityEngine;
using System.Collections;

public class TimeControl : MonoBehaviour {

	public static float enemyTimeFactor = 1f;

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("y")){
			enemyTimeFactor -= 0.05f;
		}
		if(Input.GetKeyDown("t")){
			enemyTimeFactor += 0.05f;
		}
	}

	void OnGUI(){
		GUI.Label(new Rect(10,40,200,30),"enemyTimeFactor "+enemyTimeFactor);
	}
}
