using UnityEngine;
using System.Collections;

public class TankGameLogic : MonoBehaviour {

	public GameObject enemyPrefab;

	public int roundTime = 30;
	public float timePos = 0f;

	public string gameState = "Intro";


	// Use this for initialization
	void Start () {
		roundTime = 30;
		timePos = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		if(gameState == "Intro"){
			if(Input.GetKeyDown(KeyCode.Space)){
				gameState = "Gameplay";
			}
		}else if(gameState == "Gameplay"){
			timePos += Time.deltaTime;
			if(timePos >= 1f){
				timePos = 0f;
				SpawnEnemy();
				roundTime--;
				if(roundTime <= 0){
					gameState = "GameOver";
					DestroyAllEnemies();
				}
			}
		}else if(gameState == "GameOver"){
			if(Input.GetKeyDown(KeyCode.Space)){
				Application.LoadLevel(Application.loadedLevelName);
			}
		}
	}

	private void SpawnEnemy(){
		Vector3 spawnPos = new Vector3(0f,0.5f,0f);
		spawnPos.x = Random.Range(0f,40f) - 20f;
		spawnPos.z = Random.Range(0f,40f) - 20f;
		Instantiate(enemyPrefab,spawnPos,Quaternion.identity);
	}
	private void DestroyAllEnemies(){
		GameObject []enemies = GameObject.FindGameObjectsWithTag("Enemy");
		for(int i=0;i<enemies.Length;++i){
			Destroy( enemies[i] );
		}
	}

	void OnGUI(){
		if(gameState == "Intro"){
			GUI.Label(new Rect(10,10,200,20), "Press Spacebar to start game.");
		}else if(gameState == "Gameplay"){
			GUI.Label(new Rect(10,10,200,20), "Time Left : "+roundTime);
		}else if(gameState == "GameOver"){
			if(TankScoreP1.score > TankScoreP2.score){
				GUI.Label(new Rect(10,10,200,20), "Player 1 Win!");
			}else if(TankScoreP1.score < TankScoreP2.score){
				GUI.Label(new Rect(10,10,200,20), "Player 2 Win!");
			}else{
				GUI.Label(new Rect(10,10,200,20), "Draw");
			}
			GUI.Label(new Rect(10,40,200,20), "Press Spacebar to restart game.");
		}
	}
}
