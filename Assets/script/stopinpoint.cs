using UnityEngine;
using System.Collections;

public class stopinpoint : MonoBehaviour {
	public float speed;
	public Vector3 beginPosition = new Vector3(0f,0f,0f);
	public Transform target = null;
	public float floorX = 720.755f;
	
	// Use this for initialization
	void Start () {
	
		speed = 3f;
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Translate(-speed, 0, 0);
		if(target.position.x == floorX)
		{
			speed = 0f;
		}
		
		
	}
}
