using UnityEngine;
using System.Collections;

public class spawnnpc : MonoBehaviour {

	public GameObject dnaenemyprefab;
	public Transform[]locator;
	public float timePos = 5f;
	public float  duration = 10f;
	// Use this for initialization
	public void spwanen()
	{
		int randkey = Random.Range (0, locator.Length);
		Transform spwan = locator [randkey];
		Instantiate (dnaenemyprefab, spwan.position, spwan.rotation);
		
		
		
	}
	
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		timePos += Time.deltaTime;
		if (timePos >= duration) {
			timePos = 2f;
			duration = Random.Range(15f,20f);
			spwanen();
		}
		
	}

}
