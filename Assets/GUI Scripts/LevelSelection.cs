using UnityEngine;
using System.Collections;

public class LevelSelection : MonoBehaviour {

	public GUISkin menuSkin;
	string menu = "";
	void OnGUI()
	{
		GUI.skin = menuSkin;
		
		var style = new GUIStyle();
		style.fontSize = 50;
		style.normal.textColor = Color.white;
		
		GUI.Label(new Rect(Screen.width/2 - 200, Screen.height/2 - 200, 0, 0), "Dekeract", style);
		GUI.BeginGroup(new Rect(Screen.width/2 - 150, Screen.height/2 - 100, 300, 300));
		
		GUI.Box(new Rect(0, 0, 300, 300),"Choose a Level");
		
		if (GUI.Button(new Rect (20,50,50,50), "5"))
			Application.LoadLevel("Level5");
		
		if (GUI.Button(new Rect (90,50,50,50), "4"))
			Application.LoadLevel("Level4");
		
		if (GUI.Button(new Rect (160,50,50,50), "3"))
			Application.LoadLevel("Level3");
		
		if (GUI.Button(new Rect (20,120,50,50), "6"))
			Application.LoadLevel("Level6");
		
		if (GUI.Button(new Rect (90,120,50,50), "1"))
			Application.LoadLevel("Level1");
		
		if (GUI.Button(new Rect (160,120,50,50), "2"))
			Application.LoadLevel("Level2");
		
		if (GUI.Button(new Rect (20,190,50,50), "7"))
			Application.LoadLevel("Level7");
		
		if (GUI.Button(new Rect (90,190,50,50), "8"))
			Application.LoadLevel("Level8");
		
		if (GUI.Button(new Rect (160,190,50,50), "9"))
			Application.LoadLevel("Level9");
		
		if (GUI.Button(new Rect (230,190,50,50), "10"))
			Application.LoadLevel("Level10");
			
		if (GUI.Button(new Rect (135,265,160,30), "Back"))
			Application.LoadLevel("MainMenu");
		GUI.EndGroup();
	}
}
