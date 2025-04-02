using UnityEngine;
using System.Collections;

public class TankGunP1 : MonoBehaviour {

	public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("f")){
			Instantiate(bulletPrefab,transform.position,transform.rotation);
		}
	}

	void OnGUI(){
		GUI.Label(new Rect(10,Screen.height-20f,200,20),"Press F to Fire");
	}
}
