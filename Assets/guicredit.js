#pragma strict

function Start () {

}

function Update () {
Screen.showCursor = true;
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

if(GUI.Button(Rect(250,480,400,320),start,start1 ))
{
Application.LoadLevel("start");


this.GetComponent(AudioSource).Play();
}

if(GUI.Button(Rect(100,400,500,420),how,how1 ))
{
Application.LoadLevel("how");


this.GetComponent(AudioSource).Play();
}





}