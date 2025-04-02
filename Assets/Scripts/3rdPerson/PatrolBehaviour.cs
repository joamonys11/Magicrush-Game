using UnityEngine;
using System.Collections;

public class PatrolBehaviour : MonoBehaviour {

	public Transform []locators;

	public Transform tran;
	public Transform target;
	private float threshold = 0.1f;
	public float moveSpeed = 1f;

	public int index = 0;

	// Use this for initialization
	void Start () {
		target = locators[index];
	}
	
	// Update is called once per frame
	void Update () {
		MoveToTarget();
		CheckIfReachTarget();
	}

	private void MoveToTarget(){
		tran.LookAt(target);	
		tran.position += tran.forward * moveSpeed * Time.deltaTime * TimeControl.enemyTimeFactor;
	}

	private void CheckIfReachTarget(){
		float distance = Vector3.Distance(tran.position,target.position);
		if(distance < threshold){
			ChangeTarget();
		}
	}

	private void ChangeTarget(){
		index++;
		if(index >= locators.Length){ 
			index = 0; 
		}
		target = locators[index];
	}
}
