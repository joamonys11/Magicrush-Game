using UnityEngine;
using System.Collections;

public class TestAnimController : MonoBehaviour {

	public Animator myAnimator;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("1")){
			myAnimator.SetBool("isRun",true);
		}
		if(Input.GetKeyDown("2")){
			myAnimator.SetBool("isRun",false);
		}
	}
}
