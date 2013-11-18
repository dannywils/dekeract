using UnityEngine;
using System.Collections;

public class FlashingLights : MonoBehaviour
{
	private  float maxDist = 6.0f;
	private  float speed   = 10.0f;
	private float timer   = 0.0f;
	
	// Use this for initialization
	void Start ()
	{
		light.range = 0;
	}

	// Update is called once per frame
	void Update ()
	{
		light.range = Mathf.PingPong(timer * speed, maxDist);
		timer += Time.deltaTime;
	}
}