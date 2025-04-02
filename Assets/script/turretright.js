#pragma strict
var hp : int = 15;
function Start () {

}

function Update () {


}


var bulletnpc : Transform;

function bullet()
{
Instantiate (bulletnpc, Vector3(gameObject.transform.position.x,gameObject.transform.position.y-2,gameObject.transform.position.z), Quaternion.identity);
}



function OnTriggerEnter(collisionX : Collider)

{
if(collisionX.CompareTag("player"))
{  Destroy(gameObject);	
print("impact equip");
		

	
}
if(collisionX.CompareTag("enemy"))
{	print("impact equip");
		
	hp-=5;
	Destroy(collisionX.gameObject);
	
	if(hp == 0 )
	{
	Destroy(gameObject);
	}
	
}
if(collisionX.CompareTag("mon"))
{	print("impact equip");
		
	hp-=5;
	Destroy(collisionX.gameObject);
	
	if(hp == 0 )
	{
	Destroy(gameObject);
	}
}	
if(collisionX.CompareTag("rabbit"))
{	print("impact equip");
		
	hp-=100;
	Destroy(collisionX.gameObject);
	
	if(hp < 0 )
	{
	Destroy(gameObject);
	}
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

InvokeRepeating("bullet",Random.Range(1.0,2.0),Random.Range(1.0,3.0));  //random by 2-5 second

