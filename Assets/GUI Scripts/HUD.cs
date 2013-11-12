using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {
	
	public GUISkin HUDSkin;
	public Texture PauseButton, Heart;
	public int PlayerLives;
	
	void OnGUI ()
	{
		GUI.skin = HUDSkin;
		
		if(PauseButton == null)
			GUI.Button(new Rect(Screen.width-60, 10, 50, 50), "||");
		else
			GUI.Button(new Rect(Screen.width-60, 10, 50, 50), PauseButton);
		
		GUI.Label(new Rect(10, Screen.height-40, 75, 30), "Lives:");
		for(int i = 0; i < PlayerLives; i++)
		{
			GUI.DrawTexture(new Rect(100 + i*30, Screen.height-40, 25, 25), Heart, ScaleMode.ScaleToFit);
		}
		
		GUI.Label(new Rect(Screen.width/2-160, Screen.height-40, 350, 30), "Game Time: " + Timer());
	}
	
	public string Timer()
	{
	    var hours = Mathf.Floor(Time.time/3600.0f);
	    var minutes = Mathf.Floor((Time.time - hours*3600f)/60f);
	    var seconds = Mathf.Floor(Time.time - hours*3600f - minutes*60f);
	    return string.Format(hours.ToString() + ":" + minutes.ToString() + ":" + seconds.ToString());
	} 
}