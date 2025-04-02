using UnityEngine;
using System.Collections;

public class turretspawn : MonoBehaviour {
	public GameObject []dnaEnemyPrefab;
	public Transform []locators;
	
	private float timePos = 0f;
	private float duration = 1f;
	

	public void SpawnEnemy(){
				int randKey = Random.Range (0, locators.Length);
	

				Transform spawnPoint = locators [randKey];
		int i = Random.Range (0, dnaEnemyPrefab.Length);
						Instantiate (dnaEnemyPrefab [i],
		            spawnPoint.position,
		            spawnPoint.rotation);
				}
		
	
	void Update () {
		timePos += Time.deltaTime;
		if(timePos >= duration){
			timePos = 1f;
			duration = Random.Range(15f,20f);
			SpawnEnemy();
		}
	}


	void Start () {
	}

}