using UnityEngine;
using System.Collections;

public class LearnCSharp2 : MonoBehaviour {

	void Start () {
		MainFunction();
	}

	//Variable
	private int i = 0;
	private float f = 0.0f;
	private bool b = true;
	private string t = "Hello";

	private void MainFunction(){
		Debug.Log("Hello C Sharp");

		int a = 3;

		int []jackArray = new int[3];

		jackArray[0] = 2;
		jackArray[1] = 8;
		jackArray[2] = 5;

		int []maryArray = new int[]{7,8,9};

		jackArray = maryArray;
		maryArray[0] = 999;

		int result = jackArray[0];

		//Debug.Log("result : "+result);


		Human h = new Human();
		h.name = "Raiden";

		Human g = new Human();
		g.name = "Takisawa";

		Human k = null;
		k = h;

		h = g;
		Debug.Log(h.name);
	}

	public class Human{
		public string name = "";
		public int hp = 10;
	}















}
