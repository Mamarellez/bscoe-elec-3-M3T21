using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceChangeColor : MonoBehaviour {

	public GameObject Rocket;
	public GameObject Goal;
	public float distance;

	public Color altColor = Color.white;

	public Renderer rend;
	// Use this for initialization
	void Start () {

		rend = GetComponent<Renderer> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		distance = Vector3.Distance (Rocket.transform.position, Goal.transform.position);
		print (distance);
		if (distance <= 5f && distance >=2) {
			rend.material.color = altColor;
		}
	}
}
