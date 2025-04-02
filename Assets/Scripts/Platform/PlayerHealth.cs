using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int hp = 3;
	public GameObject dnaExplosionFX;

	public bool isBlink = false;
	public int blinkCount = 0;
	public float timePos = 0f;
	public float blinkDuration = 0.1f;
	public GameObject modelPointer = null;

	void Update(){
		if(isBlink){
			UpdateBlink();
		}
	}

	private void UpdateBlink(){
		timePos += Time.deltaTime;
		if(timePos >= blinkDuration){
			timePos = 0f;
			blinkCount -= 1;
			
			if( (blinkCount % 2) == 0){
				modelPointer.SetActive(true);
			}else{
				modelPointer.SetActive(false);
			}
			
			if(blinkCount <= 0){
				isBlink = false;
				modelPointer.SetActive(true);
			}
		}
	}

	void OnTriggerEnter( Collider otherCollider ){
		if( isBlink ){
			return;
		}
		if( otherCollider.CompareTag("Enemy") || 
		   	otherCollider.CompareTag("EnemyBullet")){
			hp -= 1;
			CreateFX( otherCollider.transform.position );
			Destroy( otherCollider.gameObject );


			if(hp <= 0){
				Die();
			}else{
				BeginBlink();
			}
		}
	}

	private void BeginBlink(){
		isBlink = true;
		modelPointer.SetActive(false);
		blinkCount = 6;
	}

	private void Die(){
		CreateFX( modelPointer.transform.position );
		modelPointer.SetActive( false );
		GameLogic.gameState = "Defeat";
	}

	private void CreateFX( Vector3 pos ){
		if( dnaExplosionFX == null){ return; }
		GameObject explosionFX = Instantiate( dnaExplosionFX, 
		                                     pos, 
		                                     gameObject.transform.rotation ) as GameObject;
		Destroy( explosionFX,0.3f );
	}

}
