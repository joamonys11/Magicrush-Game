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

if(GUI.Button(Rect(250,480,400,320),start,start1 ))
{
Application.LoadLevel("scene");


this.GetComponent(AudioSource).Play();
}






}