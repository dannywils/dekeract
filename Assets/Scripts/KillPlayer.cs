using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour
{
	void OnTriggerEnter (Collider other) {
		if(other.tag == "Player"){
			Application.LoadLevel(Application.loadedLevel);
		}
	}
	void OnParticleCollision (GameObject other) {
		if(other.tag == "Player"){
			//HUD.TimePenalty = 30;
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}

