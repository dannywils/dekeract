using UnityEngine;
using System.Collections;

public class TriggerKillPlayer : MonoBehaviour
{
	void OnTriggerEnter (Collider other) {
		if(other.tag == "Player"){
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}

