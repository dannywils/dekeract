using UnityEngine;
using System.Collections;

public class RotateWorld : MonoBehaviour
{
	public float wait = 5;
	public float rotationAngle = 90;
	public float speed = 5;
	
	public GameObject world;
	public GameObject compass;
	
	//state variables
	private bool rotatable = true;
	private float lastRotate;
	private bool rotating;
	private Quaternion newRotation;

	// Use this for initialization
	void Start ()
	{
		lastRotate = Time.time - wait;
		newRotation = Quaternion.AngleAxis(rotationAngle, new Vector3(0, 0, 1));
	}
	
	// Update is called once per frame
	void Update ()
	{
		rotatable = lastRotate + wait <= Time.time;
		
		if(rotating){
			if(Mathf.Abs(world.transform.rotation.eulerAngles.z - newRotation.eulerAngles.z) <= 0.1f){
				rotating = false;
				world.transform.rotation = newRotation;
				return;
			}			
			world.transform.rotation = Quaternion.Slerp(world.transform.rotation, newRotation, speed * Time.deltaTime);
			compass.GetComponent<Compass>().angle = -world.transform.rotation.eulerAngles.z;
		}
		
		if(!rotatable){
			this.light.intensity = 0;
		} else {
			this.light.intensity = 7;
		}
	}
	
	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player" && rotatable && !rotating) {
			rotating = true;
			lastRotate = Time.time;
			audio.Play();
		}
	
	}
}
