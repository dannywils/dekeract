using UnityEngine;
using System.Collections;

public class SphereColor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.guiTexture.color = this.light.color;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
