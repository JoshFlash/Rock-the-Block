using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	public static bool isPlaying = false;

	void Awake() {
		PlayMusic();
	}
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void PlayMusic () {
		if(!isPlaying) {
			GameObject.DontDestroyOnLoad(gameObject);
			isPlaying = true;
		} else { DestroyObject(gameObject); print("MusicPlayer has been destroyed"); }
	}
}
