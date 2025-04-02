#pragma strict

var hp : int;

var explosionSFX : AudioClip;
var bombParticle : GameObject;
var animwalk : Animator;
var bulletnpc : Transform;
hp =1000;
function Start () {
}

function Update () {

if(hp == 0)
		
		{
Application.LoadLevel("gameover");
		Instantiate (bulletnpc, Vector3(gameObject.transform.position.x,gameObject.transform.position.y,gameObject.transform.position.z), Quaternion.identity);	
}
}
//bulletfornpc();



function bulletfornpc()
{
transform.Translate(4f,0,0);
Destroy(gameObject,2);



}

function OnTriggerEnter(otherCollider : Collider ){

	if( otherCollider.CompareTag("enemy")){
			hp-=5;
			print("chon11");
			Instantiate (bulletnpc, Vector3(gameObject.transform.position.x,gameObject.transform.position.y-4,gameObject.transform.position.z), Quaternion.identity);	
		
				if( explosionSFX != null ){
				AudioSource.PlayClipAtPoint( explosionSFX, 
				                             otherCollider.transform.position);
			}
		}
		
		if(otherCollider.CompareTag("mon")){
		
		hp-=5;
			Instantiate (bulletnpc, Vector3(gameObject.transform.position.x,gameObject.transform.position.y-4,gameObject.transform.position.z), Quaternion.identity);	
		if( explosionSFX != null ){
				AudioSource.PlayClipAtPoint( explosionSFX, 
				                             otherCollider.transform.position);
			}
	
		if(otherCollider.CompareTag("rabbit")){
		
		hp-=100;
			Instantiate (bulletnpc, Vector3(gameObject.transform.position.x,gameObject.transform.position.y-4,gameObject.transform.position.z), Quaternion.identity);	
		if( explosionSFX != null ){
				AudioSource.PlayClipAtPoint( explosionSFX, 
				                             otherCollider.transform.position);
			}
		
		}
		
}

}

function OnGUI(){
	

		GUI.Label(new Rect(640,50,200,20),"TURRET HEART  : "+hp);

	}




