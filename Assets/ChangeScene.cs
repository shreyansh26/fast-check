using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
	public void goToScene(string sceneName) {
		Debug.Log ("My Method was called!");
		SceneManager.LoadScene (sceneName);
	}
}
