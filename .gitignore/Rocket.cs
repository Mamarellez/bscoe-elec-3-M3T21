using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour {

	Rigidbody _rigidBody;

	void Start () {
		
		_rigidBody = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {

		ProcessInput ();
		
	}

	private void ProcessInput(){
		if (Input.GetKey(KeyCode.Space)){
			_rigidBody.AddRelativeForce(Vector3.up * Time.deltaTime * 90);
		}
		if (Input.GetKey(KeyCode.A)){
			_rigidBody.AddRelativeForce(-Vector3.left  * Time.deltaTime * 90);
		}
		if (Input.GetKey (KeyCode.D)) {
			
			_rigidBody.AddRelativeForce (Vector3.left * Time.deltaTime * 90);
		}
		if (Input.GetKey (KeyCode.S)) {

				_rigidBody.AddRelativeForce (Vector3.down * Time.deltaTime * 90);

		}
		if (Input.GetKey (KeyCode.O)) {

			SceneManager.LoadScene ("Level1");
		}


	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Ceiling" || col.gameObject.name == "Wall1" || col.gameObject.name == "Wall2" || 
			col.gameObject.name == "Ground" || col.gameObject.name == "Obstacle1" || col.gameObject.name == "Obstacle2" || col.gameObject.name == "Cube2" ||
			col.gameObject.name == "Obstacle3" || col.gameObject.name == "Obstacle4") 
		{
			SceneManager.LoadScene ("Level1");
		}
		if (col.gameObject.name == "Goal") {
			col.gameObject.GetComponent<Renderer> ().material.color = Color.green;

		}


	}
}
