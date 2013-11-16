using UnityEngine;
using System.Collections;

public class EndLevelTrigger : MonoBehaviour {
	
	private static int level = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter (Collider other) {
	    if(other.tag == "Player"){
			if(Application.levelCount > Application.loadedLevel){
				Application.LoadLevel("level" +  Application.loadedLevel);
			} else {
				//If there are no more levels left, show the "You win" scene
				Debug.Log("You win!");
				Application.LoadLevel("MainMenu");
			}
		}
	}
}
