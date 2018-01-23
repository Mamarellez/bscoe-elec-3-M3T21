using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalToNewScene2 : MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{

			
		if (col.gameObject.name == "Rocket") {
			SceneManager.LoadScene ("Level3");

		}

}
}