using UnityEngine;
using System.Collections;

public class ParticleKillPlayer : MonoBehaviour
{
	void OnTriggerEnter (Collider other) {
		if(particleSystem.particleCount > 2)
		{
			if(other.tag == "Player"){
				Application.LoadLevel(Application.loadedLevel);
			}
		}
	}
}