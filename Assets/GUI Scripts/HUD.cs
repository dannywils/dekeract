using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {
	
	public GUISkin HUDSkin;
	public Texture PauseButton, Heart;
	public int PlayerLives;
	bool paused = false;
	public int TimePenalty;
	
	void OnGUI ()
	{
		GUI.skin = HUDSkin;
		
		if(GUI.Button(new Rect(Screen.width-Screen.width/9 - 10, 10, Screen.width/9, Screen.height/9), "||"))
			paused = true;
		
		if(paused)
		{
			Time.timeScale = 0.0f;
			GUI.BeginGroup (new Rect (Screen.width / 2 - 150, Screen.height / 2 - 100, 300, 250));
			GUI.Box (new Rect (0, 0, 300, 200), "Game Paused");
			if (GUI.Button (new Rect (25, 50, 250, 30), "Resume"))
			{
				paused = false;
				Time.timeScale = 1.0f;
			}
			if (GUI.Button (new Rect (25, 100, 250, 30), "Restart Level"))
			{
				paused = false;
				Time.timeScale = 1.0f;
				Application.LoadLevel(Application.loadedLevel);
			}
			if (GUI.Button (new Rect (25, 150, 250, 30), "Main Menu"))
			{
				paused = false;
				Time.timeScale = 1.0f;
				Application.LoadLevel("MainMenu");
			}
			GUI.EndGroup();
		}
		GUI.Label(new Rect(Screen.width/2-160, Screen.height-40, 350, 30), "Game Time: " + Timer(TimePenalty));
	}
	
	public string Timer(int penalty = 0)
	{
		var hours = Mathf.Floor(Time.timeSinceLevelLoad/3600.0f);
		var minutes = Mathf.Floor((Time.timeSinceLevelLoad - hours*3600f)/60f);
		var seconds = Mathf.Floor(Time.timeSinceLevelLoad - hours*3600f - minutes*60f) + penalty;
		var hoursString = hours > 0 ? pad(hours) + ":" : "";
		return string.Format( hoursString + pad (minutes) + ":" + pad (seconds));
	} 
	
	private string pad(float number){
		if(number < 10){
			return "0" + number.ToString ();
		} else {
			return number.ToString ();
		}
	}
	
}