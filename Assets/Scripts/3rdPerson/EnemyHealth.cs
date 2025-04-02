using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	public int hp = 3;
	public GameObject enemyObject;
	public GameObject dnaExplosionFX;

	public GameObject[] dnaItemDropPrefabArray = null;

	public void ReceiveDamage(int amount){
		hp -= amount;
		if( hp <= 0 ){
			CreateFX();
			DropItem();
			Destroy( enemyObject );
		}
	}

	private void DropItem(){
		Vector3 pos = enemyObject.transform.position;
		if( dnaItemDropPrefabArray != null){
			for(int i=0;i<dnaItemDropPrefabArray.Length;++i){
				Instantiate( dnaItemDropPrefabArray[i] , pos , Quaternion.identity );
			}
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
