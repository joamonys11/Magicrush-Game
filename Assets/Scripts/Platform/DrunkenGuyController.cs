using UnityEngine;
using System.Collections;

public class DrunkenGuyController : MonoBehaviour {

	public float targetAngleZ = 0f;
	public float angleZ = 0f;
	public Transform tran = null;

	// Update is called once per frame
	void Update () {

		angleZ = Mathf.Lerp(angleZ,targetAngleZ,Time.deltaTime * 2f);

		tran.eulerAngles = new Vector3(0f,0f,angleZ);
		
	}
}
