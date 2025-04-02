using UnityEngine;
using System.Collections;

public class TankMoveP2 : MonoBehaviour {

	public float moveSpeed = 0.1f;
	
	//TODO Limit arena size
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("up")){
			transform.position += Vector3.forward * moveSpeed;
		}
		if(Input.GetKey("down")){
			transform.position -= Vector3.forward * moveSpeed;
		}
		if(Input.GetKey("right")){
			transform.position += Vector3.right * moveSpeed;
		}
		if(Input.GetKey("left")){
			transform.position -= Vector3.right * moveSpeed;
		} 
	}
}
