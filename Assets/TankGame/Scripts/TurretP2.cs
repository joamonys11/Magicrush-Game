using UnityEngine;
using System.Collections;

public class TurretP2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("up")){
			transform.localEulerAngles = new Vector3(0f,0f,0f);
		}
		if(Input.GetKey("down")){
			transform.localEulerAngles = new Vector3(0f,180f,0f);
		}
		if(Input.GetKey("right")){
			transform.localEulerAngles = new Vector3(0f,90f,0f);
		}
		if(Input.GetKey("left")){
			transform.localEulerAngles = new Vector3(0f,-90f,0f);
		} 
	}
}
