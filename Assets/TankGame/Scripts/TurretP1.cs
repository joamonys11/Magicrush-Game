using UnityEngine;
using System.Collections;

public class TurretP1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("w")){
			transform.localEulerAngles = new Vector3(0f,0f,0f);
		}
		if(Input.GetKey("s")){
			transform.localEulerAngles = new Vector3(0f,180f,0f);
		}
		if(Input.GetKey("d")){
			transform.localEulerAngles = new Vector3(0f,90f,0f);
		}
		if(Input.GetKey("a")){
			transform.localEulerAngles = new Vector3(0f,-90f,0f);
		} 
	}
}
