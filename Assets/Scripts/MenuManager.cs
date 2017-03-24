using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public void GoToScene(string sceneName) {
		SceneManager.LoadScene(sceneName);
	}

}
