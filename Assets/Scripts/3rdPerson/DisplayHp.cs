using UnityEngine;
using System.Collections;

public class DisplayHp : MonoBehaviour {

	public EnemyHealth enemyHealthPointer = null;
	public TextMesh textMeshPointer = null;
	
	// Update is called once per frame
	void Update () {
		int hp = enemyHealthPointer.hp;
		textMeshPointer.text = ""+hp;
	}
}
