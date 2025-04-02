using UnityEngine;
using System.Collections;

public class LearnCSharp : MonoBehaviour {

	void Start () {
		MainFunction();
	}

	//Variable
	private int i = 0;
	private float f = 0f;
	private bool b = true;
	private string t = "Jack";

	private void MainFunction(){
		//Debug.Log("Hello C Sharp");

		int a = 5;
		int b = 3;
		a = b;
		b = 4;

		int []intArray = new int[3];
		intArray[0] = 2;
		intArray[1] = 5;
		intArray[2] = 6;

		a = intArray[0] + intArray[1];

		int []someArray = new int[]{3,6,9};

		someArray[0] = 6;
		someArray[1] = 5;

		a = 6 + 5;
		
		//Debug.Log("a : "+a);

		int []jackArray = new int[]{2,3,4};
		int []maryArray = new int[]{7,8,9};

		maryArray = jackArray;
		jackArray[0] = 555;
		jackArray[1] = 666;
		jackArray[2] = 777;

		//int result = maryArray[0];
		//Debug.Log("result : "+result);
		/*
		Debug.Log("maryArray[0] : "+maryArray[0]);
		Debug.Log("maryArray[1] : "+maryArray[1]);
		Debug.Log("maryArray[2] : "+maryArray[2]);
		*/

		Human h = new Human();
		h.name = "Raiden";
		Human g = new Human();
		g.name = "Takisawa";

		Human j = null;
		j = h;

		h = g;
		g.name = "Jay";
		//h.name?
	}

	public class Human{
		public string name = "";
		public int hp = 10;
	}













}
