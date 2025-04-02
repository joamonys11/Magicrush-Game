#pragma strict
var explosionSFX : AudioClip;
var bombParticle : GameObject;
function Start () {

}

function Update () {
bulletfornpc();
}


function bulletfornpc()
{

transform.Translate(4f,0,0);
Destroy(gameObject,3);

}

function OnTriggerEnter(otherCollider : Collider ){

	if( otherCollider.CompareTag("enemy")){
	
		Destroy(gameObject);
			Instantiate(bombParticle,
			            otherCollider.transform.position,
			            otherCollider.transform.rotation);

			if( explosionSFX != null ){
				AudioSource.PlayClipAtPoint( explosionSFX, 
				                             otherCollider.transform.position);
			}
		}
		
		if( otherCollider.CompareTag("mon")){
			
print("bullright");
		Destroy(gameObject);
			Instantiate(bombParticle,
			            otherCollider.transform.position,
			            otherCollider.transform.rotation);

			if( explosionSFX != null ){
				AudioSource.PlayClipAtPoint( explosionSFX, 
				                             otherCollider.transform.position);
			}
		}
		if( otherCollider.CompareTag("rabbit")){

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

