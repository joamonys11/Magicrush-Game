using UnityEngine;
using System.Collections;

public class FEZPlatformController : MonoBehaviour {

	public Transform fezModelPlatform;
	public GameObject[] groupSideArray;
	public Transform modelPointer;

	public MovementController movementController;

	// Use this for initialization
	void Start () {
		ChangeSide(0);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("1")){
			ChangeSide(0);
		}
		if(Input.GetKeyDown("2")){
			ChangeSide(1);
		}
	}

	public void ChangeSide(int index){
		StopAllCoroutines();
		StartCoroutine( CoChangeSide(index) );
	}

	private IEnumerator CoChangeSide(int index){
		groupSideArray[0].SetActive(false);		
		groupSideArray[1].SetActive(false);
		movementController.enabled = false;
		GameObject eye = new GameObject("eye");
		eye.transform.localEulerAngles = Vector3.up * (index == 0 ? 0f:90f );
		float timePos = 0f;
		float duration = 1.5f;

		while(timePos < duration){
			timePos += Time.deltaTime;
			fezModelPlatform.rotation = Quaternion.Lerp(fezModelPlatform.rotation,
			                                            eye.transform.rotation,
			                                            Time.deltaTime * 5f);
			modelPointer.rotation = fezModelPlatform.rotation;
			yield return null;
		}
		fezModelPlatform.rotation = eye.transform.rotation;
		modelPointer.rotation = fezModelPlatform.rotation;
		movementController.enabled = true;
		Destroy(eye);
		groupSideArray[index].SetActive(true);
	}
}
