using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour {


	Rigidbody _rigidBody;
	public float time = 0;

	void Start () {

		_rigidBody = GetComponent<Rigidbody>();

	}

	// Update is called once per frame
	void Update () {

		ProcessInput ();

	}

	private void ProcessInput(){
		if (Input.GetKey (KeyCode.Space)) {
			_rigidBody.AddRelativeForce (Vector3.up * Time.deltaTime * 90);
			print ("_rigidBody");

	


		}
	}
}
