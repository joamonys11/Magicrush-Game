using UnityEngine;
using System.Collections;

public class DoorBehaviour : MonoBehaviour {

	public Transform doorTran;
	public Transform closeLocator;
	public Transform openLocator;

	public bool isOpen = false;

	void Update () {
		Vector3 targetPos = new Vector3(0f,0f,0f);
		if(isOpen){ 
			targetPos = openLocator.position;
		}else{
			targetPos = closeLocator.position;
		}

		//Move door position to target position
		doorTran.position = Vector3.Lerp(doorTran.position,
		                                 targetPos,
		                                 Time.deltaTime * 5f );
	}
}



