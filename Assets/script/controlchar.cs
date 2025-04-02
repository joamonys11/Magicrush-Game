using UnityEngine;
using System.Collections;

public  class controlchar : MonoBehaviour {
	
	//--- Fields
	public AudioClip explosionSFX ;
	public AudioClip winSFX ;

	public CharacterController myCharacterController;
	public float runSpeed = 5f;
	public float gravity = 10f;
	public float jumpSpeed = 6f;
	public float steerSpeed = 10f;
	public int controlMode = 0;
	public Animator animwalk;
	private Transform _tran;
	private Vector3 moveVector = Vector3.zero;
	public float velocityY = 0f;
	private float oldMouseX = 0f;
	private float threshold = 0.001f;
	public bool isRunning = false;
	public Transform bulletSpawnLocator;
	public int i = 0;
	public  int fire = 0;
	public int water = 0;
	public int yellow = 0;
	public int firer = 0;
	public int waterr = 0;
	public int yellowr = 0;
	public int energy = 0;
	public GameObject firet;
	public GameObject watert;
	public GameObject yellowt;
	public GameObject fireri;
	public GameObject waterri;
	public GameObject yellowri;
	public int heart = 100;
	public static int fire1;



	//--- MonoBehaviour Method ---
	void Awake(){
		_tran = myCharacterController.transform;
	}
	
	void Start () {
		oldMouseX = Input.mousePosition.x;
		Screen.showCursor = false;
		fire1 = fire;

		Screen.showCursor = true;
	}
	
	void Update () {
		moveVector = Vector3.zero;
		//TODO Add run logic
		/*if( GameLogic.gameState == "Gameplay"){
			if(controlMode == 0){
				//

				MouseSteerUpdate();
			}else{
				//RunUpdate();
				SideStepUpdate();
				KeyboardSteerUpdate();
			}
		}*/
		//RunUpdate();
		runSpeed = 500;
		SpawnBullet ();
		move ();
		SideStepUpdate();
		GravityAndJump();
		//UpdateIsRunning();

		myCharacterController.Move(moveVector);
		if (heart < 0) {

			Application.LoadLevel("gameover");

				}
	}
	
	//--- My Custom Method ---
	
	
	private void RunUpdate(){
		float vValue = Input.GetAxis("Vertical");
		
		Vector3 direction = _tran.forward;
		float      scalar = vValue * runSpeed * Time.deltaTime;
		Vector3 resultVector = direction * scalar;
		moveVector += resultVector;
	}
	private void SideStepUpdate(){
		float hValue = Input.GetAxis("Horizontal");
		
		Vector3 direction = _tran.right;
		float      scalar = hValue * runSpeed * Time.deltaTime;
		Vector3 resultVector = direction * scalar;
		moveVector += resultVector;
	}
	private void MouseSteerUpdate(){
		float mouseDiffX = Input.mousePosition.x - oldMouseX;
		float hValue = mouseDiffX;
		float scalar = hValue * steerSpeed * Time.deltaTime;
		_tran.Rotate(0f,scalar,0f );
		
		oldMouseX = Input.mousePosition.x;
	}
	
	public int maxJump = 2;
	public int jumpCount = 0;
	
	private void GravityAndJump()
	{

			if(Input.GetKey(KeyCode.Space))
			{
				if( jumpCount < maxJump){
					velocityY = jumpSpeed;
					jumpCount++;
				}
			}



		if(myCharacterController.isGrounded)
		{
			velocityY = 0f;
			jumpCount = 0;
		}
		else
		{
			velocityY += gravity *7* Time.deltaTime;
		}
		
		moveVector.y += velocityY*7*Time.deltaTime;
	}

	
	public Transform test;
	private void KeyboardSteerUpdate(){
		float vValue = Input.GetAxis("Vertical");
		float hValue = Input.GetAxis("Horizontal");
		float damping = 10f;
		
		Vector3 targetEulerAngle = new Vector3(0f,Mathf.Atan2(vValue,-hValue)*Mathf.Rad2Deg-90f,0f);
		
		if(isRunning){
			Quaternion targetQuaternion = Quaternion.Euler(targetEulerAngle);
			test.localRotation = Quaternion.Lerp(
				test.localRotation,
				targetQuaternion,
				damping*Time.deltaTime
				);
		}
	}
	
	public bool GetIsRunning(){
		return isRunning;
	}
	
	private void UpdateIsRunning(){
		float xzMoveDistance = Mathf.Abs( moveVector.x ) + Mathf.Abs( moveVector.z );
		if(xzMoveDistance > threshold){
			isRunning = true;
		}else{
			isRunning = false;
		}
	}



	private void move()
	{
		if (Input.GetKey (KeyCode.RightArrow)) {
			animwalk.SetBool ("walkright", true);
		} else {
			animwalk.SetBool ("walkright", false);
			
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			animwalk.SetBool ("walkleft", true);
		} else {
			
			animwalk.SetBool ("walkleft", false);
			
		}
		
		
	}



	private void SpawnBullet()
	{

				if (Input.GetKeyDown (KeyCode.F)) {
						if (fire > 0) {

								GameObject go = Instantiate (firet,
		                             bulletSpawnLocator.position,
		                             bulletSpawnLocator.rotation) as GameObject;
								
								fire--; 

			} else if (firer > 0) {

								GameObject go = Instantiate (fireri,
				                             bulletSpawnLocator.position,
				                             bulletSpawnLocator.rotation) as GameObject;

								firer--; 

						}
				}

				if (Input.GetKeyDown (KeyCode.W)) {
						if (water > 0) {
					
								GameObject go = Instantiate (watert,
					                             bulletSpawnLocator.position,
					                             bulletSpawnLocator.rotation) as GameObject;
								water--;
					
						} else if (waterr > 0) {
								GameObject go = Instantiate (waterri,
				                             bulletSpawnLocator.position,
				                             bulletSpawnLocator.rotation) as GameObject;
								waterr--;

			
						}




				}

		
		if (Input.GetKeyDown (KeyCode.E)) {
			if (yellow > 0) {
				
				GameObject go = Instantiate (yellowt,
				                             bulletSpawnLocator.position,
				                             bulletSpawnLocator.rotation) as GameObject;
				yellow--;
				
			} else if (yellowr > 0) {
				GameObject go = Instantiate (yellowri,
				                             bulletSpawnLocator.position,
				                             bulletSpawnLocator.rotation) as GameObject;
				yellowr--;
				
				
			}
			
			
			
			
		}

				


		
		}

	
	void OnTriggerEnter(Collider other){
		
		if (other.CompareTag ("fire")) {

						fire+=1;
			print("chon");
				} else if (other.CompareTag ("water")) {
			print("chon");
						water+= 1;
				} else if (other.CompareTag ("yellow")) {
			print("chon");
						yellow+= 1;
				} else if (other.CompareTag ("fireri")) {
					
			print("chon");
						firer+= 1;
				} else if (other.CompareTag ("waterri")) {

			print("chon");
						waterr+= 1;
				} else if (other.CompareTag ("yellowri")) {

			print("chon");
			yellowr = 1;
		}else if (other.CompareTag("enemy")) {
			print("hp-");
			heart-=10;
			Destroy(other.gameObject);
			if( explosionSFX != null ){
				AudioSource.PlayClipAtPoint( explosionSFX, 
				                            other.transform.position);
			}
		}else if(other.CompareTag ("mon")) 
		{
			
			heart-=10;
			Destroy(other.gameObject);
			if( explosionSFX != null ){
				AudioSource.PlayClipAtPoint( explosionSFX, 
				                            other.transform.position);
			}
		}else if (other.CompareTag ("rabbit")) {
			//print ("hp-");
			heart-=20;
			Destroy(other.gameObject);
			if( explosionSFX != null ){
				AudioSource.PlayClipAtPoint( explosionSFX, 
				                           other.transform.position);
			}
		}else if(other.CompareTag("energy"))
	     	{
			print("chon");
				
				energy +=1;

				if(energy == 5)
				{
				Application.LoadLevel("win");
				if( winSFX != null ){
					AudioSource.PlayClipAtPoint( winSFX, 
					                            other.transform.position);
				}

			}
	      }




		}



	void OnGUI(){
		GUI.Label(new Rect(10,20,200,20),"Heart : "+heart);

		GUI.Label(new Rect(1200,20,200,20),"FireturretRight : "+fire);
		GUI.Label(new Rect(1200,40,200,20),"FireturretLeft : "+firer);
		GUI.Label(new Rect(1200,60,200,20),"WaterturretRight : "+water);
		GUI.Label(new Rect(1200,80,200,20),"WaterturretLeft : "+waterr);
		GUI.Label(new Rect(1200,100,200,20),"YellowturretRight : "+yellow);
		GUI.Label(new Rect(1200,120,200,20),"YellowturretLeft : "+yellowr);

		GUI.Label(new Rect(640,20,200,20),"Energy : "+energy);

	}



		
}