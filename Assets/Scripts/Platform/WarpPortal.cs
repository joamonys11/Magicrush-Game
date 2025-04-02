using UnityEngine;
using System.Collections;

public class WarpPortal : MonoBehaviour {

	public GameObject target = null;
	public Transform[] locatorArray = null;

	public void Warp(int index){
		if(target == null){ return; }
		if(locatorArray == null){ return; }

		target.transform.position = locatorArray[index].position;
	}

	/*
	private float timePos = 0f;
	private float duration = 2f;
	private bool isTimeTicking = true;

	void Update(){
		if(isTimeTicking){
			timePos += Time.deltaTime;
			if(timePos >= duration){
				Warp(2);
				isTimeTicking = false;
			}
		}
	}
	 */
	
	/*
	void Update () {
		for(int i=0;i<locatorArray.Length;++i){
			if( Input.GetKeyDown(""+i) ){
				Warp( i );
			}
		}
	}*/

}
