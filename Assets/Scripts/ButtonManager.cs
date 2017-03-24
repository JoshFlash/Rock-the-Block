using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ButtonManager : MonoBehaviour {

	public int blocksLeft;
	public AudioSource audioSrc;

	void Start() {
		blocksLeft = Block.breakableBlocks;
		audioSrc = GetComponent<AudioSource>();
	}

	void Update() {
		print(blocksLeft);
		if (blocksLeft>Block.breakableBlocks) {
			blocksLeft--;
			audioSrc.Play();
		}
	}

	public void GoToScene(string sceneName) {
		SceneManager.LoadScene(sceneName);
	}

	public void GoToGameLevel(int n) {

		if (n==0) { n = Random.Range(1, 4); print(n); }

		string levelName = "GameLevel" + n;
		Debug.Log(levelName);
		GoToScene(levelName); 

	}

	public void ExitGame() {
		Application.Quit();
	}
}
