using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour {

	public static string gameState = "Intro";
	//Intro
	//Gameplay
	//Victory
	//Defeat

	public Transform playerTranPointer = null;

	void Awake(){
		gameState = "Gameplay";
	}

	void Update(){
		if(gameState == "Gameplay"){
			if(playerTranPointer.position.x >= 40f){
				gameState = "Victory";
			}
		}
	}

}
