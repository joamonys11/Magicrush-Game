using UnityEngine;
using System.Collections;

public class WaitAndDoSomething : MonoBehaviour {

	public float timePos = 0f;
	public float duration = 1f;

	public int index = 0;

	void Start(){
		enabled = false;
	}

	public void DoSomethingAfterDelay(int _index, float delayTime){
		enabled = true;
		timePos = 0f;
		index = _index;
		duration = delayTime;
	}

	void Update(){
		timePos += Time.deltaTime;
		if( timePos >= duration ){
			DoSomething();
			enabled = false;
			timePos = 0;
		}
	}

	public DoorBehaviour doorBehaviourPointer = null;
	public DoorBehaviour doorBehaviourPointer2 = null;

	private void DoSomething(){
		if(index == 0){
			doorBehaviourPointer.isOpen = true;
		}else if( index == 1){
			doorBehaviourPointer2.isOpen = true;
		}
	}

}
