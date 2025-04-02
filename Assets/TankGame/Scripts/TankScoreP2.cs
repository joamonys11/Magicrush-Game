using UnityEngine;
using System.Collections;

public class TankScoreP2 : MonoBehaviour {

	public static int score = 0;
	
	void Start(){
		score = 0;
	}
	
	void OnGUI(){
		GUI.Label(new Rect(10,30,200,20),"P2 Score : "+score);
	}
}
