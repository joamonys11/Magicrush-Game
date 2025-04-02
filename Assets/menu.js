#pragma strict

function Start () {

}

function Update () {

}






var start : Texture;
var how : Texture;
var start1 : GUIStyle;
var how1 : GUIStyle;
var credit :Texture;
var credit1 :GUIStyle;
var exit : Texture;
var exit1 : GUIStyle;
function OnGUI()
{

if(GUI.Button(Rect(300,480,400,320),start,start1 ))
{
Application.LoadLevel("scene");


this.GetComponent(AudioSource).Play();
}


if(GUI.Button(Rect(110,450,500,400),how,how1))
{
Application.LoadLevel("how");
this.GetComponent(AudioSource).Play();
}

if(GUI.Button(Rect(1200,560,200,150),credit,credit1))
{
Application.LoadLevel("credit");
this.GetComponent(AudioSource).Play();
}


}