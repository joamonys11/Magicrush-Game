using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TextParticle : MonoBehaviour {

	public static Transform parentPool;
	public static Object _dna;
	public static List<TextParticle> activeList = new List<TextParticle>();
	public static List<TextParticle> storeList  = new List<TextParticle>();
	private static int maxObjects = 50;

	public static void ResetParent(){
		if(_dna == null){
			_dna = Resources.Load("Prefabs/Text Particle");
		}
		GameObject go = new GameObject("TextParticle Pool");
		parentPool = go.transform;
		activeList.Clear();
		storeList.Clear();
	}

	public static TextParticle Spawn(Vector3 pos,string text,Color _color ,float _factor = 1.5f){
		if(parentPool == null || parentPool.Equals(default(Transform))){
			ResetParent();
		}
		int index = 0;
		while(storeList.Count > 0){
			if(storeList[index] != null){
				storeList[index].Setup( pos,text,_color,_factor);
				TextParticle temp = storeList[index];
				activeList.Add( temp );
				storeList.RemoveAt(index);
				return temp;
			}else{
				storeList.RemoveAt(index);
			}
		}

		if(storeList.Count + activeList.Count >= maxObjects){ return null; }

		GameObject go = Instantiate( _dna,pos,Quaternion.identity) as GameObject;
		go.transform.parent = parentPool;
		TextParticle tmp = go.GetComponent<TextParticle>() as TextParticle;
		tmp.Setup( pos,text,_color,_factor);
		activeList.Add(tmp);
		return tmp;
	}

	public void Setup(Vector3 pos,string text,Color _color ,float _factor = 1.5f){
		transform.position = pos;
		textMesh.text = text;
		factor = _factor;
		duration = 1f*factor;
		flySpeed = 0.5f/factor;
		timePos = 0f;
		textMesh.color = _color;
		gameObject.SetActive(true);
	}

	private float flySpeed = 0.5f;
	private float duration = 1f;
	private float timePos = 0f;
	private float factor = 1.5f;

	public TextMesh textMesh;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.up*flySpeed*Time.deltaTime;
		Color _color = textMesh.color;
		_color.a = 1f-(timePos/duration);
		textMesh.color = _color;
		timePos += Time.deltaTime;
		if(timePos >= duration){ 
			timePos = 0f;
			storeList.Add(this);
			activeList.Remove(this);
			gameObject.SetActive(false);
		}
	}
}
