using UnityEngine;
using System.Collections;

public class SuperSimpleGun : MonoBehaviour {

	public enum ControlMode{
		None,
		Mouse,
		Keyboard,
	}

	public Transform bulletSpawnLocator;
	public GameObject dnaBulletPrefab;
	public ControlMode mode = ControlMode.Keyboard;

	private float fireInterval = 0.1f;
	private float timePos = 0f;

	private bool isShooting = false;
	public bool GetIsShooting(){
		return isShooting;
	}

	void Update () {	
		if( GameLogic.gameState != "Gameplay"){
			return;
		}

		if(mode == ControlMode.Mouse){
			if( Input.GetMouseButtonDown(0) ){
				isShooting = true;
			}
		}else if(mode == ControlMode.Keyboard){
			if( Input.GetKeyDown(KeyCode.Space) ){
				isShooting = true;
			}
		}else{
			isShooting = false;
		}


		if( isShooting ){
			timePos += Time.deltaTime;
			if(timePos >= fireInterval){
				timePos -= fireInterval;
				SpawnBullet();
			}

		}

		if(mode == ControlMode.Mouse){
			if( Input.GetMouseButtonUp(0) ){
				timePos = 0f;
				isShooting = false;
			}
		}else if(mode == ControlMode.Keyboard){
			if( Input.GetKeyUp(KeyCode.Space) ){
				timePos = 0f;
				isShooting = false;
			}
		}else{
			isShooting = false;
		}
	}

	private void SpawnBullet(){
		GameObject go = Instantiate( dnaBulletPrefab,
		                            bulletSpawnLocator.position,
		                            bulletSpawnLocator.rotation) as GameObject;
	}

	private void OnGUI(){
		string descriptionText = "";
		if( mode == ControlMode.Keyboard ){
			descriptionText = "Press [Spacebar] to Fire.";
		}else if(mode == ControlMode.Mouse){
			descriptionText = "Left Click to Fire.";
		}
		GUI.Label(new Rect(10,10,200,20),descriptionText);
	}
}
