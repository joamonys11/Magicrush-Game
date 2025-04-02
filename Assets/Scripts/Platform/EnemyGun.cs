using UnityEngine;
using System.Collections;

public class EnemyGun : MonoBehaviour {
	public GameObject dnaBulletPrefab = null;
	public Transform gunTranPointer = null;
	private Transform playerTranPointer = null;
	public float timePos = 0f;
	public float duration = 1f;

	private void FireBullet(){

		GameObject bullet = Instantiate( dnaBulletPrefab ) as GameObject;
		bullet.transform.position = gunTranPointer.position;
		if(playerTranPointer.position.x < gunTranPointer.position.x){
			bullet.transform.eulerAngles = new Vector3(0f,-90f,0f);
		}else{
			bullet.transform.eulerAngles = new Vector3(0f,90f,0f);
		}
	}

	void Start () {
		playerTranPointer = GameObject.FindGameObjectWithTag("Player").transform;
	}	

	void Update () {
		if(GameLogic.gameState != "Gameplay"){
			return;
		}
		timePos += Time.deltaTime;
		if(timePos >= duration){
			timePos = 0f;
			FireBullet();
		}
	}
}
