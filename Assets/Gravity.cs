using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {

	Rigidbody rb;
	public GameObject sun;
	public static float gravity = 9.8f;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 up = Vector3.Normalize(sun.transform.position - transform.position);
		rb.AddForce (-up * gravity);
	}
}
