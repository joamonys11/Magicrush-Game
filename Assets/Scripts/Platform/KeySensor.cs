using UnityEngine;
using System.Collections;

public class KeySensor : MonoBehaviour {

	public int count = 0;
	public int collectAmount = 3;
	public bool isCollected = false;

	void OnTriggerEnter(Collider otherCollider){
		if(isCollected){ return; }

		if(otherCollider.CompareTag("Key")){
			count++;
			otherCollider.gameObject.SetActive(false);
			if(count >= collectAmount){
				isCollected = true;
				DoSomething();
			}
		}
	}

	public PlayerHealth playerHealthPointer = null;

	public void DoSomething(){
		//Write your own code here.
		Debug.Log("Keys collected.");

		//playerHealthPointer.hp += 3;
		GameLogic.gameState = "Victory";
	}

}
