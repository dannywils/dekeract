using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
	public GUISkin menuSkin;
	string menu = "";
	
	void OnGUI ()
	{
		GUI.skin = menuSkin;
		
		var style = new GUIStyle ();
		style.fontSize = 50;
		style.normal.textColor = Color.white;
		
		GUI.Label (new Rect (Screen.width / 2 - 200, Screen.height / 2 - 200, 0, 0), "Dekeract", style);
		
		switch (menu) {
		case "help":
			GUI.BeginGroup (new Rect (Screen.width / 2 - 250, Screen.height / 2 - 100, 500, 500));
			GUI.Box (new Rect (0, 0, 500, 300), "");
			GUI.Label (new Rect (10, 10, 490, 290), "ADD HELP DATA");
			if (GUI.Button (new Rect (335, 265, 160, 30), "Back"))
				menu = "";
			break;
		case "storyline":
			GUI.BeginGroup (new Rect (Screen.width / 2 - 250, Screen.height / 2 - 100, 500, 500));
			GUI.Box (new Rect (0, 0, 500, 300), "");
			GUI.Label (new Rect (10, 10, 490, 290), "ADD STORYLINE DATA");
			if (GUI.Button (new Rect (335, 265, 160, 30), "Back"))
				menu = "";
			break;
		case "about":
			GUI.BeginGroup (new Rect (Screen.width / 2 - 250, Screen.height / 2 - 100, 500, 500));
			GUI.Box (new Rect (0, 0, 500, 300), "");
			GUI.Label (new Rect (10, 10, 490, 290), "This game was created for a final project in our game design class " +
			           "(CSCI 4168) at Dalhousie University. The game is created by:");
			GUI.Label (new Rect (20, 100, 490, 20), "Danny Wilson");
			GUI.Label (new Rect (20, 130, 490, 20), "Rob Moore");
			GUI.Label (new Rect (20, 160, 490, 20), "Matthew Coelho");
			if (GUI.Button (new Rect (335, 265, 160, 30), "Back"))
				menu = "";
			break;
		default:
			GUI.BeginGroup (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 200));
			GUI.Box (new Rect (0, 0, 300, 300), "");
			if (GUI.Button (new Rect (20, 30, 160, 30), "Play"))
				Application.LoadLevel ("LevelSelection");
			if (GUI.Button (new Rect (20, 70, 160, 30), "Help"))
				menu = "help";
			if (GUI.Button (new Rect (20, 110, 160, 30), "Storyline"))
				menu = "storyline";
			if (GUI.Button (new Rect (20, 150, 160, 30), "About"))
				menu = "about";
			break;
		}
		GUI.EndGroup ();
	}
}