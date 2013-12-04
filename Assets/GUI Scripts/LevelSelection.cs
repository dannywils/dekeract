using UnityEngine;
using System.Collections;

public class LevelSelection : MonoBehaviour
{
	public GUISkin menuSkin;
	private int lastLevel;
	public Texture Star;

	void Start ()
	{
		//PlayerPrefs.DeleteAll();
		lastLevel = PlayerPrefs.GetInt ("lastLevel");
	}

	void OnGUI ()
	{
		GUI.skin = menuSkin;
	
		var style = new GUIStyle ();
		style.fontSize = 50;
		style.normal.textColor = Color.white;
		int width = Screen.width / 2;
		int height = Screen.height / 2;
		int xOffset = 0;
		int yOffset = 20;

		int buttonPadding = 5;




		GUI.Label (new Rect (width - 200, height/4, 0, 0), "Dekeract", style);

		GUI.BeginGroup (new Rect (width / 2, height / 2 + yOffset, width, height));


		GUI.Box (new Rect (0, 0, width, height), "");

		int rows = 2;
		int columns = 5;
		int index = 0;
		for (int i = 0; i < rows; i++)
		{
			for (int j = 0; j < columns; j++)
			{
				index++;
				if (Application.levelCount - 2 > index)
				{
					if (lastLevel >= index)
					{
						//if the user clicked the button
						if (GUI.Button (new Rect (width / columns * j, (height - 2 * yOffset) / rows * i, width / columns, (height - 2 * yOffset) / rows), index.ToString ()))
						{
							//if the level exists, load it
							Application.LoadLevel ("Level" + index);
						} 
					}
					else 
					{
						//level is locked
						GUI.Button (new Rect (width / columns * j, (height - 2 * yOffset) / rows * i, width / columns, (height - 2 * yOffset) / rows), "X");
					}
				}
				else
				{
					//Level was not found
					GUI.Button (new Rect (width / columns * j, (height - 2 * yOffset) / rows * i, width / columns, (height - 2 * yOffset) / rows), "?");
				}
			}
		}  

		//return to the main menu
		if (GUI.Button (new Rect (width / 2, height - 2 * yOffset, width / 2, 2 * yOffset), "Back")) {
			Application.LoadLevel ("MainMenu");
		}

		GUI.EndGroup ();

		GUI.Label(new Rect (5, 150, 230, 30), " Level 1 Score:");
		if(PlayerPrefs.HasKey("level1Score")){
			int stars = PlayerPrefs.GetInt("level1Score");
			for(int n = 1; n <= stars; n++)
			{
				GUI.DrawTexture(new Rect (185  + (20 * n), 150, 25, 25), Star, ScaleMode.ScaleToFit);
			}
		}
		GUI.Label(new Rect (5, 180, 230, 30), " Level 2 Score:");
		if(PlayerPrefs.HasKey("level2Score")){
			int stars = PlayerPrefs.GetInt("level2Score");
			for(int n = 1; n <= stars; n++)
			{
				GUI.DrawTexture(new Rect (185  + (20 * n), 180, 25, 25), Star, ScaleMode.ScaleToFit);
			}
		}
		GUI.Label(new Rect (5, 210, 230, 30), " Level 3 Score:");
		if(PlayerPrefs.HasKey("level3Score")){
			int stars = PlayerPrefs.GetInt("level3Score");
			for(int n = 1; n <= stars; n++)
			{
				GUI.DrawTexture(new Rect (185  + (20 * n), 210, 25, 25), Star, ScaleMode.ScaleToFit);
			}
		}
		GUI.Label(new Rect (5, 240, 230, 30), " Level 4 Score:");
		if(PlayerPrefs.HasKey("level4Score")){
			int stars = PlayerPrefs.GetInt("level4Score");
			for(int n = 1; n <= stars; n++)
			{
				GUI.DrawTexture(new Rect (185  + (20 * n), 240, 25, 25), Star, ScaleMode.ScaleToFit);
			}
		}
		GUI.Label(new Rect (5, 270, 230, 30), " Level 5 Score:");
		if(PlayerPrefs.HasKey("level5Score")){
			int stars = PlayerPrefs.GetInt("level5Score");
			for(int n = 1; n <= stars; n++)
			{
				GUI.DrawTexture(new Rect (185  + (20 * n), 270, 25, 25), Star, ScaleMode.ScaleToFit);
			}
		}
		GUI.Label(new Rect (5, 300, 230, 30), " Level 6 Score:");
		if(PlayerPrefs.HasKey("level6Score")){
			int stars = PlayerPrefs.GetInt("level6Score");
			for(int n = 1; n <= stars; n++)
			{
				GUI.DrawTexture(new Rect (185  + (20 * n), 300, 25, 25), Star, ScaleMode.ScaleToFit);
			}
		}
		GUI.Label(new Rect (5, 330, 230, 30), " Level 7 Score:");
		if(PlayerPrefs.HasKey("level7Score")){
			int stars = PlayerPrefs.GetInt("level7Score");
			for(int n = 1; n <= stars; n++)
			{
				GUI.DrawTexture(new Rect (185  + (20 * n), 330, 25, 25), Star, ScaleMode.ScaleToFit);
			}
		}
		GUI.Label(new Rect (5, 360, 230, 30), " Level 8 Score:");
		if(PlayerPrefs.HasKey("level8Score")){
			int stars = PlayerPrefs.GetInt("level8Score");
			for(int n = 1; n <= stars; n++)
			{
				GUI.DrawTexture(new Rect (185  + (20 * n), 360, 25, 25), Star, ScaleMode.ScaleToFit);
			}
		}
		GUI.Label(new Rect (5, 390, 230, 30), " Level 9 Score:");
		if(PlayerPrefs.HasKey("level9Score")){
			int stars = PlayerPrefs.GetInt("level9Score");
			for(int n = 1; n <= stars; n++)
			{
				GUI.DrawTexture(new Rect (185  + (20 * n), 390, 25, 25), Star, ScaleMode.ScaleToFit);
			}
		}
		GUI.Label(new Rect (5, 420, 230, 30), " Level 10 Score:");
		if(PlayerPrefs.HasKey("level10Score")){
			int stars = PlayerPrefs.GetInt("level10Score");
			for(int n = 1; n <= stars; n++)
			{
				GUI.DrawTexture(new Rect (185  + (20 * n), 420, 25, 25), Star, ScaleMode.ScaleToFit);
			}
		}
	}
}
