using UnityEngine;
using System.Collections;

public class SyncAnimationWithMovement : MonoBehaviour {

	public MovementController myMovementController;
	public ModelController myModelController;

	private Animator myAnimator;

	void Awake(){
		myAnimator = myModelController.modelAnimator;
	}
	
	// Update is called once per frame
	void Update () {
		if(myMovementController == null){ return; }
		if(myAnimator == null){ return; }

		myAnimator.SetBool("isRun",myMovementController.GetIsRunning() );
	}
}
