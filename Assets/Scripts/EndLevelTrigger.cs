using UnityEngine;
using System.Collections;

public class EndLevelTrigger : MonoBehaviour {
	
	private int lastLevel;
	// Use this for initialization
	void Start () {
		lastLevel = PlayerPrefs.GetInt ("lastLevel");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter (Collider other) {
	    if(other.tag == "Player"){
			int nextLevel = Application.loadedLevel + 2;
			
			if(Application.levelCount  > nextLevel + 1){
				Application.LoadLevel("level" +  nextLevel);
				if(nextLevel > lastLevel){
					PlayerPrefs.SetInt("lastLevel", Application.loadedLevel + 1);
				}
			} else {
				//If there are no more levels left, show the "You win" scene
				Debug.Log("You win!");
				Application.LoadLevel("MainMenu");
			}
		}
	}
}
