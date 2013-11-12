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
		if(LevelMusic.Length > level-2 && level >= 2){
			audio.Stop();
			audio.PlayOneShot(LevelMusic[level-2]);
		}
    }
	
}
