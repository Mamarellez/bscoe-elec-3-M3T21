﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalToNewScene : MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{

			
		if (col.gameObject.name == "Rocket") {
			SceneManager.LoadScene ("Level2");

		}

}
}