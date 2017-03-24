using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOptions : MonoBehaviour {

	public static int maxBalls = 3;
	public static bool ballsDecreasedByUser = false;
	Text gameBalls;

	void Start() {
		gameBalls = GetComponent<Text>();

	}

	void Update () {
		gameBalls.text = ( "Game Balls: " + maxBalls );
	}
	
	public void IncreaseMaxBalls() {
		if (maxBalls<10) {
			maxBalls++;
			if (maxBalls>3) {
				ballsDecreasedByUser = false;
			}
		}
	}

	public void DecreaseMaxBalls() {
		if  (maxBalls>1) {
			maxBalls--;
			if (maxBalls<=2) {
				ballsDecreasedByUser = true;
			}
		}
	}

}
