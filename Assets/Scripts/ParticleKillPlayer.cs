using UnityEngine;
using System.Collections;

public class ParticleKillPlayer : MonoBehaviour
{
	private ParticleSystem.CollisionEvent[] collisionEvents = new ParticleSystem.CollisionEvent[16];

	void OnParticleCollision(GameObject other)
	{
		int safeLength = particleSystem.safeCollisionEventSize;

		if (collisionEvents.Length < safeLength)
			collisionEvents = new ParticleSystem.CollisionEvent[safeLength];
		
		int numCollisionEvents = particleSystem.GetCollisionEvents(other, collisionEvents);
		int i = 0;
		while (i < numCollisionEvents) {
			if (other.gameObject.tag == "Player") {
				Application.LoadLevel(Application.loadedLevelName);
			}
			i++;
		}
	}
}
