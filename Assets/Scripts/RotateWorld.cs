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

	// Use this for initialization
	void Start ()
	{
		lastRotate = Time.time - wait;
	}
	
	// Update is called once per frame
	void Update ()
	{
		rotatable = lastRotate + wait <= Time.time;
		if(rotating){
			Quaternion newRotation = Quaternion.AngleAxis(rotationAngle, new Vector3(0, 0, 1));
			
			world.transform.rotation = Quaternion.Slerp(world.transform.rotation, newRotation, speed * Time.deltaTime);

			Compass game = compass.GetComponent<Compass>();
			game.angle = world.transform.rotation.eulerAngles.z + 180;

			if(transform.rotation == newRotation){
				rotating = false;
			}
			
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
