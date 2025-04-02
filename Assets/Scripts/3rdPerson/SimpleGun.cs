using UnityEngine;
using System.Collections;

public class SimpleGun : MonoBehaviour {

	public Transform bulletSpawnLocator;
	public GameObject dnaBulletPrefab;

	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			FireBullet();
		}
	}

	private void FireBullet(){
		StartCoroutine( FireSequence(0.05f) );
	}

	private IEnumerator FireSequence(float intervalTime){
		while( true ){
			if( !Input.GetMouseButton(0)){ 
				break; 
			}

			SpawnBullet();
			yield return new WaitForSeconds( intervalTime );
		}
	}

	private void SpawnBullet(){
		GameObject go = Instantiate( dnaBulletPrefab,
		                            bulletSpawnLocator.position,
		                            bulletSpawnLocator.rotation) as GameObject;

		StartCoroutine( BulletMove(go,40f,1.5f) );
	}

	private IEnumerator BulletMove(GameObject bullet,float moveSpeed,float lifeTime){
		float timePos = 0f;
		while( bullet != null ){

			timePos += Time.deltaTime;
			if(timePos >= lifeTime){
				Destroy(bullet);
				break;
			}

			bullet.transform.position += bullet.transform.forward * moveSpeed * Time.deltaTime;
			yield return null;
		}
	}
}
