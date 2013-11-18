using UnityEngine;
using System.Collections;

public class RotateWorld : MonoBehaviour
{
	public float wait = 5;
	public float rotationAngle = 90;
	public float speed = 500;
	public GameObject world;
	public GameObject compass;
	
	//state variables
	private bool rotatable = true;
	private float lastRotate;
	private bool rotating;
	private Quaternion newRotation;
	private GameObject player;
	private float rotationAmt = 0;
	private float currentRotation;
	private float needToRotate;
	private float direction;
	private float endTime;
	private float startTime;

	// Use this for initialization
	void Start ()
	{
		startTime = Time.time;
		lastRotate = startTime - wait;
		newRotation = Quaternion.AngleAxis (rotationAngle, new Vector3 (0, 0, 1));
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update ()
	{
		rotatable = lastRotate + wait <= Time.time;

		if (rotating) {

			if (rotationAmt > Mathf.Abs (needToRotate)) {
				rotating = false;
				world.transform.rotation = newRotation;
				compass.GetComponent<Compass> ().angle = -world.transform.rotation.eulerAngles.z;
				return;
			}
			//rotate the world around the player
			world.transform.RotateAround (player.transform.position, new Vector3 (0, 0, 1), direction * speed * Time.deltaTime);
			rotationAmt += speed * Time.deltaTime;
			//rotate the compass too		
			compass.GetComponent<Compass> ().angle = -world.transform.rotation.eulerAngles.z;

		}
		//animate the intensity of light
		if (!rotatable) {
			light.range = Mathf.InverseLerp(lastRotate, lastRotate + wait + 1, Time.time) * 4 + 1;
			light.intensity = 2;
		} else{
			light.intensity = 8;
		}
	}
	
	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player" && rotatable && !rotating) {
			rotationAmt = 0;
			currentRotation = world.transform.rotation.eulerAngles.z;
			needToRotate = Mathf.DeltaAngle (currentRotation, rotationAngle);
			if(needToRotate != 0){
				rotating = true;
			}
			direction = needToRotate > 0 ? 1 : -1;
			
			lastRotate = Time.time;
			audio.Play ();
		}
	}
}
