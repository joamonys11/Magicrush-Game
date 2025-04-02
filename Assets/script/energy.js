#pragma strict

function Start () {

}

function Update () {

Destroy(gameObject,60);
}





function OnTriggerEnter(collisionX : Collider)

{
if(collisionX.CompareTag("player"))
{  Destroy(gameObject);	
print("impact equip");
		

	
}

	
	
	
}


/*function OnCollisionEnter(collisionX : Collision)

{
if(collisionX.gameObject.name=="water(Clone)")
{	print("impact");
controler.score+=100;
	GameObject.Find("score").guiText.text = "SCORE :  "+controler.score;
	Destroy(gameObject);
	
}
	
	if(collisionX.gameObject.name == "attack_0"){
	controler.playerHeart--;
	controler.score+=100;
	GameObject.Find("score").guiText.text = "SCORE :  "+controler.score;
	GameObject.Find("Heart").guiText.text = " "+controler.playerHeart;
		Destroy(gameObject);
	}
	
	
	
	
}
*/


