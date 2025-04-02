using UnityEngine;
using System.Collections;

public class TankScoreP1 : MonoBehaviour {

	public static int score = 0;

	void Start(){
		score = 0;
	}

	void OnGUI(){
		GUI.Label(new Rect(10,20,200,20),"P1 Score : "+score);
	}

}
