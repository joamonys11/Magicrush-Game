using UnityEngine;
using System.Collections;

public class LearnCSharp4 : MonoBehaviour {

	public HumanMono aMono;
	public HumanMono bMono;

	// Use this for initialization
	void Start () {
		MainFunction();
	}

	private void MainFunction(){
		aMono.name = "Johny";
		bMono.name = "Derp";
	}

	private void OldMainFunction(){
		Human a = new Human();
		a.name = "Johny";
		a.hp = 20;
		Human b = new Human();
		b.name = "Derp";
		b.hp = 10;
		Human leader = null;
		leader = a;
		leader.atkDamage *= 2;
		leader = null;
		a.Attack(b);
		Debug.Log("a hp : "+a.GetHp());
		Debug.Log("b hp : "+b.GetHp());
	}
	public class Human{
		public string name = "";
		public int hp = 10;
		public int atkDamage = 3;
		public void Attack(Human target){
			target.hp -= atkDamage;
		}
	
		public int GetHp(){
			return hp;
		}
		public void TellMyName(){
			Debug.Log("My name is : "+name);
		}

		
	}








}
