using UnityEngine;
using System.Collections;
//always rotate the camera


public class RotateCamera : MonoBehaviour {
	
	public float speed = 0;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
	}
}
