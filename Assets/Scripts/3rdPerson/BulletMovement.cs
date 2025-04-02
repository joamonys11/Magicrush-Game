using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

	public Transform bulletTran;
	public float moveSpeed = 40f;
	
	void Update () {
		bulletTran.position += bulletTran.forward * moveSpeed * Time.deltaTime;
	}
}
