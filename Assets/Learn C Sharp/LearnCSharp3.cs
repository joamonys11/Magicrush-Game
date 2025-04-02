using UnityEngine;
using System.Collections;
public class LearnCSharp3 : MonoBehaviour {
	// Use this for initialization
	void Start () {
		MainFunction();
	}

	private void MainFunction(){
		Human m = new Human();
		m.name = "Johny";
		m.atkDamage = 3;
		m.hp = 15;

		Human n = new Human();
		n.name = "Derp";
		n.hp = 3;

		n.Attack(m);
		m.Attack(n);
		Debug.Log("m HP : "+m.hp);
		Debug.Log("n HP : "+n.hp);
	}
	
	public class Human{
		public string name = "";
		public int hp = 10;
		public int atkDamage = 1;

		public void Attack(Human target){
			target.hp -= atkDamage;
		}
		
		public void AddHp(int amount){
			hp += amount;
		}
		public void TellMyName(){
			Debug.Log("My name is : "+name);
		}
		public int GetHp(){
			return hp;
		}

	}
}
