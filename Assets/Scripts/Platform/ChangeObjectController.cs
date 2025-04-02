using UnityEngine;
using System.Collections;

public class ChangeObjectController : MonoBehaviour {

	public int index = 0;
	public GameObject[] objectArray;

	void Start(){
		ChangeIndex(index);
	}

	public void ChangeIndex(int newIndex){
		int oldIndex = index;

		objectArray[oldIndex].SetActive(false);
		objectArray[newIndex].SetActive(true);
		objectArray[newIndex].transform.position = 
			objectArray[oldIndex].transform.position;

		index = newIndex;
	}
}




