using UnityEngine;
using System.Collections;

public class SimpleEnemySpawner : MonoBehaviour {

	public GameObject dnaEnemyPrefab = null;
	public Transform locatorPointer = null;

	public float timePos = 0f;
	public float duration = 3f;
	
	void Update () {
		timePos += Time.deltaTime;
		if(timePos >= duration){
			timePos = 0f;
			SpawnEnemy();
		}
	}

	private void SpawnEnemy(){
		Instantiate( dnaEnemyPrefab, 
		            locatorPointer.position, 
		            locatorPointer.rotation);
	}
}
