using UnityEngine;
using System.Collections;

public class RespawnIfFall : MonoBehaviour {

	public Vector3 beginPosition = new Vector3(0f,0f,0f);
	public Transform target = null;
	public float floorY = -100f;

	// Use this for initialization
	void Awake () {
		beginPosition = target.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(target.position.y < floorY){
			target.position = beginPosition;
			DoSomething();
		}
	}

	public void DoSomething(){
		//Write your own code here.
		Debug.Log("Target is falling, now move target back to begin position.");
	}
}
