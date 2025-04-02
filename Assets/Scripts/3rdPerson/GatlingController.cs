using UnityEngine;
using System.Collections;

public class GatlingController : MonoBehaviour {

	public Transform gatling;
	public SuperSimpleGun myGun;

	
	// Update is called once per frame
	void Update () {
		if(myGun.GetIsShooting()){
			gatling.Rotate(0f,0f,1000f*Time.deltaTime);
		}
	}
}
