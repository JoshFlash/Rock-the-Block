using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public bool autoplay = false;
	public Ball ball;


	void Start() {
		ball = GameObject.FindObjectOfType<Ball>();
	}

	// Update is called once per frame
	void Update () {
		if (!autoplay) {
			MoveUsingMouse();
		} else {
			AutoPlay();
		}

	}

	void MoveUsingMouse() {
		Vector3 paddlePos = new Vector3(8.0f, 0.35f, 0.0f);
		float mouseXpos = Input.mousePosition.x / Screen.width * 16;
		paddlePos.x = Mathf.Clamp(mouseXpos, 0.5f, 15.5f);
		transform.position = paddlePos;
	}

	void AutoPlay() {
		Vector3 paddlePos = new Vector3(8.0f, 0.35f, 0.0f);
		Vector3 ballPos = ball.transform.position;
		paddlePos.x = Mathf.Clamp(ballPos.x, 0.5f, 15.5f);
		transform.position = paddlePos;
	}


}
