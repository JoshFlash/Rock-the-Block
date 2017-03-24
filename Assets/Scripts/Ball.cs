using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Ball : MonoBehaviour {

	private Paddle paddle;
	Rigidbody2D rigidBody;
	private Vector3 paddleToBallVector;

	public bool unlaunched = true;

	public AudioSource boing;

	// Use this for initialization
	void Start () {
		boing = GetComponent<AudioSource>();
		paddle = GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector = (this.transform.position - paddle.transform.position);
		rigidBody = gameObject.GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
		if(unlaunched) {
			this.transform.position = paddle.transform.position + paddleToBallVector;
			if (Input.GetMouseButtonDown(0)) {
				LaunchBall();
			}
		} else if (Block.breakableBlocks <=0) {
			SceneManager.LoadScene("WinScreen");	
		}
	}

	void OnCollisionEnter2D (Collision2D collision) {
		if(!unlaunched) boing.Play();

		Vector2 tweak = new Vector2(Random.Range(-0.1f, 0.2f), Random.Range(-0.1f, 0.2f));
		rigidBody.velocity += tweak;
		//print(tweak);
	}

	//LaunchBall is called at the start of the level to launch the ball
	void LaunchBall () {
		unlaunched = false;
		rigidBody.velocity = new Vector2(2f, 10f);
	}
}
