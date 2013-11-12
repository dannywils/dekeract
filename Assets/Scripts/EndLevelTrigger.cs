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
			if(Application.levelCount > level){
				level++;
				Application.LoadLevel("level" +  level);
			} else {
				Debug.Log("You win!");
				Application.Quit ();
			}
		}
	}
}
