 using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
	public GUISkin menuSkin;
	string menu = "";

	void OnGUI ()
	{
					int width = Screen.width / 2;
			int height = Screen.height / 2;
			int xOffset = 0;
			int yOffset = 20;

		GUI.skin = menuSkin;
		
		var style = new GUIStyle ();
		style.fontSize = 50;
		style.normal.textColor = Color.white;
		
		GUI.Label (new Rect (width - 200, height/4, 0, 0), "Dekeract", style);
		GUI.BeginGroup (new Rect (width/2, height/2 + yOffset, width, height));
		GUI.Box (new Rect (0, 0, width, height), "");
		switch (menu) {
		case "help":

			GUI.Label (new Rect (10, 10, width, 290), "ADD HELP DATA");
			if (GUI.Button (new Rect (335, 265, 160, 30), "Back"))
				menu = "";
			break;
		case "storyline":

			GUI.Label (new Rect (10, 10, width - 20, height - 20), "ADD STORYLINE DATA");
			if (GUI.Button (new Rect (335, 265, 160, 30), "Back"))
				menu = "";
			break;
		case "about":

			GUI.Label (new Rect (10, 10, width, height), "This game was created for a final project in our game design class " +
					"(CSCI 4168) at Dalhousie University. The game is created by:");
			GUI.Label (new Rect (20, 100, 490, 20), "Danny Wilson");
			GUI.Label (new Rect (20, 130, 490, 20), "Rob Moore");
			GUI.Label (new Rect (20, 160, 490, 20), "Matthew Coelho");
			if (GUI.Button (new Rect (335, 265, 160, 30), "Back"))
				menu = "";
			break;
		default:

			int buttonPadding = 5;




			if (GUI.Button (new Rect (buttonPadding, height/4 * 0 + buttonPadding, width - 2 * buttonPadding, height/4 - 2 * buttonPadding), "Play"))
				Application.LoadLevel ("LevelSelection");
			if (GUI.Button (new Rect (buttonPadding, height/4 * 1 + buttonPadding, width - 2 * buttonPadding, height/4 - 2 * buttonPadding), "Help"))
				menu = "help";
			if (GUI.Button (new Rect (buttonPadding, height/4 * 2 + buttonPadding, width - 2 * buttonPadding, height/4 - 2 * buttonPadding), "Storyline"))
				menu = "storyline";
			if (GUI.Button (new Rect (buttonPadding, height/4 * 3 + buttonPadding, width - 2 * buttonPadding,  height/4 - 2 * buttonPadding ), "About"))
				menu = "about";
			break;
		}
		GUI.EndGroup ();
	}
}
