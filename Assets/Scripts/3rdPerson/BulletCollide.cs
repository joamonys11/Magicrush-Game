using UnityEngine;
using System.Collections;

public class BulletCollide : MonoBehaviour {

	public GameObject dnaExplosionFX;

	void OnTriggerEnter(Collider other){

		if(other.CompareTag("Wall")){
			Destroy(gameObject);
			CreateFX();
		}else if(other.CompareTag("Enemy")){
			other.gameObject.SendMessage("ReceiveDamage",1);
//			EnemyHealth enemyHealth = other.gameObject.GetComponent<EnemyHealth>() as EnemyHealth;
//			enemyHealth.ReceiveDamage(1);


			Destroy(gameObject);
			CreateFX();
		}
	}

	private void CreateFX(){
		if( dnaExplosionFX == null){ return; }
		GameObject explosionFX = Instantiate( dnaExplosionFX, 
		                                     gameObject.transform.position, 
		                                     gameObject.transform.rotation ) as GameObject;
		Destroy( explosionFX,0.3f );
	}
}
