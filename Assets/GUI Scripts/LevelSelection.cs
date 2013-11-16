using UnityEngine;
using System.Collections;

public class LevelSelection : MonoBehaviour {

	public GUISkin menuSkin;
	private int lastLevel;
	
	void Start(){
		//PlayerPrefs.DeleteAll();
		lastLevel = PlayerPrefs.GetInt("lastLevel");
	}
	void OnGUI()
	{
		GUI.skin = menuSkin;
		
		var style = new GUIStyle();
		style.fontSize = 50;
		style.normal.textColor = Color.white;
		
		GUI.Label(new Rect(Screen.width/2 - 200, Screen.height/2 - 200, 0, 0), "Dekeract", style);
		GUI.BeginGroup(new Rect(Screen.width/2 - 150, Screen.height/2 - 100, 300, 300));
		
		GUI.Box(new Rect(0, 0, 300, 300),"Choose a Level");
		
		int index = 0;
		for(int i = 0; i < 2; i++){
			for(int j = 0; j < 5; j++){
				index++;
				if(Application.levelCount > index + 1){
					if(lastLevel + 1 >= index){
						//if the user clicked the button
						if (GUI.Button(new Rect (15 + 55 * j , 95 * i + 45,50,90), index.ToString())){
							//if the level exists, load it
							Application.LoadLevel("Level" + index);
						} 
					} else {
						//level is locked
						GUI.Button(new Rect (15 + 55 * j , 95 * i + 45,50,90), "✘");
					}
				} else {
					//Level was not found
					GUI.Button(new Rect (15 + 55 * j , 95 * i + 45,50,90), "");
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
