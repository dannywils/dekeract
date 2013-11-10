using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	void OnGUI()
	{
		GUI.BeginGroup(new Rect(Screen.width/2 - 100, Screen.height/2 - 100, 200, 200));
		// Make a background box
		GUI.Box(new Rect(0, 0, 300, 300),"");
		// Make the first button. If it is pressed,
		// Application.Loadlevel(1) will be executed
		if (GUI.Button(new Rect (50,30,100,20), "Play"))
			Application.LoadLevel(1);
		if (GUI.Button(new Rect (50,70,100,20), "Help"))
			Application.LoadLevel(2);
		if (GUI.Button(new Rect (50,110,100,20), "Storyline"))
			Application.LoadLevel(3);
		if (GUI.Button(new Rect (50,150,100,20), "About"))
			Application.LoadLevel(4);
		GUI.EndGroup();
	}
}
