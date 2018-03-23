using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject sun;
	public float sensitivity;
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	float mouseAngle = 0;
	// Update is called once per frame
	void Update () {
		Vector3 up = Vector3.Normalize(sun.transform.position - transform.position);
		transform.rotation = Quaternion.AngleAxis(0,up) * transform.rotation;

		mouseAngle += Input.GetAxis ("Mouse X") * sensitivity;
		if (mouseAngle > 360) {
			mouseAngle -= 360;
		}
		if (mouseAngle < 0) {
			mouseAngle += 360;
		}

		transform.rotation = Quaternion.Euler (0, mouseAngle, 0);
		Quaternion tilt = Quaternion.FromToRotation (Vector3.up, up);
		transform.rotation = tilt * transform.rotation;
		rb.AddForce(transform.forward * Input.GetAxis("Vertical") * 10);

	
	}
}
