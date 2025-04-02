using UnityEngine;
using System.Collections;

public class rabright : MonoBehaviour {
	public float speed;
	public float floorX = 720.755f;
	
	public GameObject bombParticle;
	public AudioClip explosionSFX;
	public int hp = 20;
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
			hp-=1;
			if (hp == 0 )
			{
				Destroy(gameObject);
				Instantiate(bombParticle,
				            otherCollider.transform.position,
				            otherCollider.transform.rotation);


			}

			if( explosionSFX != null ){
				AudioSource.PlayClipAtPoint( explosionSFX, 
				                            otherCollider.transform.position);
			}
		}

		if (otherCollider.CompareTag ("castle")) {
			print ("rabbit");
			Destroy(gameObject);
			Instantiate(bombParticle,
			            otherCollider.transform.position,
			            otherCollider.transform.rotation);
		}
	}
}
