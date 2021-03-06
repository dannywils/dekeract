﻿using UnityEngine;
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
					if (lastLevel >= index || index == 1)
					{
						//if the user clicked the button
						int stars = PlayerPrefs.GetInt("level" + index + "Score");
						Debug.Log (stars);
						for(int n = 1; n <= stars; n++)
						{
							GUI.DrawTexture(new Rect (width / columns * j  + (20 * n), (height - 2 * yOffset) / rows * i, 25, 25), Star, ScaleMode.ScaleToFit);
						}
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

	}
}
