using UnityEngine;
using System.Collections;
 
public class SmoothFollow2D : MonoBehaviour
{
	public float dampTime = 0.15f;
	public float zoomSpeed = 2;
	public float startFOV = 180;
	public Transform target;
	
	private Vector3 velocity = Vector3.zero;
	private Vector3 delta;
	private float zoom;
	private float endFOV;
	private float initialEndFOV;
	void Start ()
	{

		if (target) {
			delta = transform.position - target.position;
		}
		
		endFOV = camera.fieldOfView;
		initialEndFOV = endFOV;
		camera.fieldOfView = startFOV;
		
		
	}
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey ("z")) {
			endFOV = 80;
		} else {
			endFOV = initialEndFOV;
		}
		if (target) {
			Vector3 destination = target.position + delta;
			transform.position = Vector3.SmoothDamp (transform.position, destination, ref velocity, dampTime);
			camera.fieldOfView = Mathf.Lerp (camera.fieldOfView, endFOV, zoomSpeed * Time.deltaTime);
		}
 
	}
}
