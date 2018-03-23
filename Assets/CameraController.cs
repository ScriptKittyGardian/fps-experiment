using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {


	public float lookLimit = 90;
	public float sensitivity = 5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float currentRotation = transform.localEulerAngles.x;
		currentRotation += Input.GetAxis ("Mouse Y") * -sensitivity;
		transform.localEulerAngles = new Vector3 (currentRotation,0,0);
	}
}
