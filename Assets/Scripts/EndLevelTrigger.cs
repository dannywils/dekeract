using UnityEngine;
using System.Collections;

public class EndLevelTrigger : MonoBehaviour {
	
	private int lastLevel;
	// Use this for initialization
	void Start () {
		lastLevel = PlayerPrefs.GetInt ("lastLevel");
		////PlayerPrefs.DeleteAll();
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnTriggerEnter (Collider other) {
	    if(other.tag == "Player"){
			var hours = Mathf.Floor(Time.timeSinceLevelLoad/3600.0f);
			var minutes = Mathf.Floor((Time.timeSinceLevelLoad - hours*3600f)/60f);

			if(minutes < 1 )
			{
				PlayerPrefs.SetInt(Application.loadedLevelName.ToLower ()+"Score", 3);
			}
			else if(minutes < 2)
			{
				PlayerPrefs.SetInt(Application.loadedLevelName.ToLower ()+"Score", 2);
			}
			else
			{
				PlayerPrefs.SetInt(Application.loadedLevelName.ToLower ()+"Score", 1);
			}
			Debug.Log (Application.loadedLevelName+"Score");
			int nextLevel = Application.loadedLevel - 1;
			if(Application.levelCount - 2 > nextLevel){
				Application.LoadLevel("level" +  nextLevel);
				if(nextLevel > lastLevel){
					PlayerPrefs.SetInt("lastLevel", nextLevel);
				}
			} else {
				//If there are no more levels left, show the "You win" scene
				Debug.Log("You win!");
				Application.LoadLevel("GameOver");
			}
		}
	}
}
