using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoseBallCollider : MonoBehaviour {

	public int ballsLeft;

	private Ball ball;

	void Start() {
		ballsLeft = GameOptions.maxBalls;
		ball = GameObject.FindObjectOfType<Ball>();
	}

	void OnTriggerEnter2D (Collider2D trigger) {
		ballsLeft--;
		GameOptions.maxBalls--;
		if (ballsLeft<=0) {
			SceneManager.LoadScene("LoseScreen");
		} 
		else {ball.unlaunched = true; }
	}

}
