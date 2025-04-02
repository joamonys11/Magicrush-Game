using UnityEngine;
using System.Collections;

public class TankMoveP1 : MonoBehaviour {

	public float moveSpeed = 0.1f;

	//TODO Limit arena size

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("w")){
			transform.position += Vector3.forward * moveSpeed;
		}
		if(Input.GetKey("s")){
			transform.position -= Vector3.forward * moveSpeed;
		}
		if(Input.GetKey("d")){
			transform.position += Vector3.right * moveSpeed;
		}
		if(Input.GetKey("a")){
			transform.position -= Vector3.right * moveSpeed;
		} 
	}
}
