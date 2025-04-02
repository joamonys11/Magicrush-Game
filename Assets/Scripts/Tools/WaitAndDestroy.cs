using UnityEngine;
using System.Collections;

public class WaitAndDestroy : MonoBehaviour {

	public float lifeTime = 1.5f;
	public GameObject go;

	void Start () {
		StartCoroutine( DestroyAfterTime(lifeTime) );
	}

	private IEnumerator DestroyAfterTime(float _lifeTime){
		yield return new WaitForSeconds( _lifeTime );
		Destroy( go );
	}
}
