using UnityEngine;
using System.Collections;

public class TankGunP2 : MonoBehaviour {

	public GameObject bulletPrefab;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("m")){
			Instantiate(bulletPrefab,transform.position,transform.rotation);
		}
	}

	void OnGUI(){
		GUI.Label(new Rect(10+Screen.width/2,Screen.height-20f,200,20),"Press M to Fire");
	}
}
