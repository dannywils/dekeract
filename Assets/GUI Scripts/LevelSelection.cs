using UnityEngine;
using System.Collections;

public class LevelSelection : MonoBehaviour {

	public GUISkin menuSkin;

	void OnGUI()
	{
		GUI.skin = menuSkin;
		
		var style = new GUIStyle();
		style.fontSize = 50;
		style.normal.textColor = Color.white;
		
		GUI.Label(new Rect(Screen.width/2 - 200, Screen.height/2 - 200, 0, 0), "Dekeract", style);
		GUI.BeginGroup(new Rect(Screen.width/2 - 150, Screen.height/2 - 100, 300, 300));
		
		GUI.Box(new Rect(0, 0, 300, 300),"Choose a Level");
		
		int count = 0;
		for(int i = 0; i < 2; i++){
			for(int j = 0; j < 5; j++){
				count++;
				//if the user clicked the button
				if (GUI.Button(new Rect (15 + 55 * j , 95 * i + 45,50,90), count.ToString())){
					//if the level exists, load it
					if(Application.levelCount > (count + 1)){
						Application.LoadLevel("Level" + count);
					} else {
						Debug.Log ("Level " + count + " doesn't exist");
					}
				}
			}
		}
		//return to the main menu
		if (GUI.Button(new Rect (135,265,160,30), "Back")){
			Application.LoadLevel("MainMenu");
		}

		GUI.EndGroup();
	}
}
