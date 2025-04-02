using UnityEngine;
using System.Collections;

public class TestCharactorController : MonoBehaviour {

	public CharacterController myCharactorController;	

	private Vector3 moveVector = new Vector3(0f,0f,0f);

	void Update () {
		moveVector = new Vector3(0f,0f,0f);

		//moveVector += new Vector3(0f,0f,1f * Time.deltaTime);
		moveVector += myCharactorController.transform.forward * Time.deltaTime;


		myCharactorController.Move( moveVector );	
	}
}
