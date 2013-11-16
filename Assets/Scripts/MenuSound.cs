using UnityEngine;
using System.Collections;


public class MenuSound : MonoBehaviour {
	
	public AudioClip MenuMusic;
	public AudioClip[] LevelMusic;
	
	void Awake ()
	{
		DontDestroyOnLoad (gameObject);
	}
	// Use this for initialization
	void Start () {
		audio.PlayOneShot(MenuMusic);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnLevelWasLoaded(int level) {
		Debug.Log ("Scene " + level + " loaded.");
		if(LevelMusic.Length > level-2 && level >= 2){
			//if we're on a level, play that level's music
			audio.Stop();
			audio.PlayOneShot(LevelMusic[level-2]);
		} else if (level == 0){ 
			//if we are back at the menu, play the menu music
			audio.Stop();
			audio.PlayOneShot(MenuMusic);
		}
    }
	
}
