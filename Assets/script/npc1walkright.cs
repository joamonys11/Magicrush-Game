using UnityEngine;
using System.Collections;

public class npc1walkrigh : MonoBehaviour {
	public float speed;
	public float floorX = 720.755f;
	
	public GameObject bombParticle;
	public AudioClip explosionSFX;
	// Use this for initialization
	void Start () {

		speed = 1f;

	}
	
	// Update is called once per frame
	void Update () {

	
		transform.Translate(-speed, 0, 0);


	
	}



	void OnTriggerEnter(Collider otherCollider){
		
		if( otherCollider.CompareTag("bulletturret")){
			Destroy( otherCollider.gameObject );
			
			Destroy(gameObject);
			Instantiate(bombParticle,
			            otherCollider.transform.position,
			            otherCollider.transform.rotation);
			
			if( explosionSFX != null ){
				AudioSource.PlayClipAtPoint( explosionSFX, 
				                            otherCollider.transform.position);
			}
		}
	}
}
