using UnityEngine;
using System.Collections;

public class MinimapPosition : MonoBehaviour
{
 
	private GameObject player;
 
	void Start() {
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	void OnPreRender ()
	{
		player.light.enabled = true;

	}
 
	void OnPostRender ()
	{
		player.light.enabled = false;
	}
}