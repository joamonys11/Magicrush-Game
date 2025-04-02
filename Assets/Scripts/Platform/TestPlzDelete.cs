using UnityEngine;
using System.Collections;

public class TestPlzDelete : MonoBehaviour {

	public WaitAndDoSomething waitAndDoSomethingPointer = null;

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("p")){
			waitAndDoSomethingPointer.DoSomethingAfterDelay(0,2f);
		}
		if(Input.GetKeyDown("k")){
			waitAndDoSomethingPointer.DoSomethingAfterDelay(1,5f);
		}
	}
}
