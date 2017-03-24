using UnityEngine;
using System.Collections;

//This calss is attached to the play space to run at load time for each level
// It addresses the issues of 0 Game Balls and Breakale count required to win.
public class LevelLoad : MonoBehaviour {

	void Awake() {
		Block.breakableBlocks = 0;
		if( GameOptions.maxBalls <= 2 && !GameOptions.ballsDecreasedByUser ) {
			GameOptions.maxBalls = 3;
		}
	}

	// Use this for initialization
	void Start () {
		if (GameOptions.ballsDecreasedByUser) {
			GameOptions.ballsDecreasedByUser = false; //reset this setting at load time
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
