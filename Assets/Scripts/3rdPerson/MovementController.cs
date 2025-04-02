using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour {
	
	//--- Fields
	public CharacterController myCharacterController;
	public float runSpeed = 5f;
	public float gravity = 10f;
	public float jumpSpeed = 6f;
	public float steerSpeed = 10f;
	public int controlMode = 0;

	private Transform _tran;
	private Vector3 moveVector = Vector3.zero;
	public float velocityY = 0f;
	private float oldMouseX = 0f;
	private float threshold = 0.001f;
	public bool isRunning = false;

	//--- MonoBehaviour Method ---
	void Awake(){
		_tran = myCharacterController.transform;
	}

	void Start () {
		oldMouseX = Input.mousePosition.x;
		Screen.showCursor = false;
	}

	void Update () {
		moveVector = Vector3.zero;
		//TODO Add run logic
		if( GameLogic.gameState == "Gameplay"){
			if(controlMode == 0){
				//RunUpdate();
				SideStepUpdate();
				MouseSteerUpdate();
			}else{
				//RunUpdate();
				SideStepUpdate();
				KeyboardSteerUpdate();
			}
		}

		GravityAndJump();
		UpdateIsRunning();
		myCharacterController.Move(moveVector);
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
		if( GameLogic.gameState == "Gameplay"){
			if(Input.GetKeyDown("up") || Input.GetKeyDown("w"))
			{
				if( jumpCount < maxJump){
					velocityY = jumpSpeed;
					jumpCount++;
				}
			}
		}
		if(myCharacterController.isGrounded)
		{
			velocityY = 0f;
			jumpCount = 0;
		}
		else
		{
			velocityY += gravity * Time.deltaTime;
		}

		moveVector.y += velocityY*Time.deltaTime;
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
}
