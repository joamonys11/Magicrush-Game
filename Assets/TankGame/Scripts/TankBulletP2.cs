using UnityEngine;
using System.Collections;

public class TankBulletP2 : MonoBehaviour {

	public float moveSpeed = 1f;	
	public GameObject spawnFX;
	public GameObject hitFX;
	
	void Start () {
		Destroy(gameObject, 1.5f);
		Instantiate( spawnFX, transform.position,transform.rotation );
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.forward * moveSpeed;
	}
	
	void OnTriggerEnter(Collider otherCollider){
		if(otherCollider.tag == "Enemy"){
			
			Instantiate( hitFX, transform.position,transform.rotation );
			
			Destroy(gameObject);
			Destroy(otherCollider.gameObject);
			
			TankScoreP2.score += 1;
		}
	}
}
