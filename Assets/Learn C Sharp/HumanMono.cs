using UnityEngine;
using System.Collections;

public class HumanMono : MonoBehaviour {

	public string name = "";
	public int hp = 10;

	public int atkDamage = 3;
	public void Attack(HumanMono target){
		target.hp -= atkDamage;
	}
	
	public int GetHp(){
		return hp;
	}
	public void TellMyName(){
		Debug.Log("My name is : "+name);
	}

}
