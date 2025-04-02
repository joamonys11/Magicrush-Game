using UnityEngine;
using System.Collections;

public class PatrolBetweenTwoPoint : MonoBehaviour {
	public Transform targetPointer = null;
	public Transform firstWaypointPointer = null;
	public Transform secondWaypointPointer = null;
	public Transform modelTranPointer = null;
	public float moveSpeed = 1f;
	public int waypointIndex = 1;	

	void Update () {
		if(waypointIndex == 1){
			MoveToFirstWaypoint();
		}else{
			MoveToSecondWaypoint();
		}
	}

	private void MoveToFirstWaypoint(){
		if(targetPointer.position.x < firstWaypointPointer.position.x){
			Vector3 movePos = new Vector3( moveSpeed * Time.deltaTime,0f,0f);
			targetPointer.position += movePos;
			modelTranPointer.localEulerAngles = new Vector3(0f,90f,0f);
		}else{
			Vector3 movePos = new Vector3( -moveSpeed * Time.deltaTime,0f,0f);
			targetPointer.position += movePos;
			modelTranPointer.localEulerAngles = new Vector3(0f,-90f,0f);
		}


		float distance = targetPointer.position.x - 
			firstWaypointPointer.position.x;

		distance = Mathf.Abs(distance);

		if(distance < 0.1f * moveSpeed ){
			waypointIndex = 2;
		}
	}

	private void MoveToSecondWaypoint(){
		if(targetPointer.position.x < secondWaypointPointer.position.x){
			Vector3 movePos = new Vector3( moveSpeed * Time.deltaTime,0f,0f);
			targetPointer.position += movePos;
			modelTranPointer.localEulerAngles = new Vector3(0f,90f,0f);
		}else{
			Vector3 movePos = new Vector3( -moveSpeed * Time.deltaTime,0f,0f);
			targetPointer.position += movePos;
			modelTranPointer.localEulerAngles = new Vector3(0f,-90f,0f);
		}

		float distance = targetPointer.position.x - 
			secondWaypointPointer.position.x;
		distance = Mathf.Abs(distance);
		if(distance < 0.1f * moveSpeed ){
			waypointIndex = 1;
		}
	}
}







