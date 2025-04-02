using UnityEngine;
using System.Collections;

public class ChaseBehaviour : MonoBehaviour {

	public Transform target;
	public Transform tran;

	public float moveSpeed = 1f;

	private GameObject eye;

	void Start(){
		eye = new GameObject("eye");
		eye.transform.parent = tran;
	}
	
	// Update is called once per frame
	void Update () {
		//Rotate immediately
		//tran.LookAt(target);

		//Rotate with lerp
		eye.transform.LookAt(target);
		tran.rotation = Quaternion.Lerp(tran.rotation,eye.transform.rotation,
		                                Time.deltaTime * TimeControl.enemyTimeFactor);

		//Move
		tran.position += tran.forward * moveSpeed * Time.deltaTime * TimeControl.enemyTimeFactor;

	}
}
