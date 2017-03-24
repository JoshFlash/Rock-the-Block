using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	public static int breakableBlocks = 0;

	private int timesHit;
	private bool isBreakable;
	private SpriteRenderer spriteRend;

	public AudioSource audioSrc;
	public GameObject smoke;
	public Sprite[] spriteHit;


	void Awake() {
		isBreakable = ( this.tag == "Breakable" );
		if( isBreakable ) {
			breakableBlocks++;
		}
	}

	// Use this for initialization
	void Start () {
		timesHit = 0;
		spriteRend = this.GetComponent<SpriteRenderer>();
		audioSrc = GetComponent<AudioSource>();
	}

	void OnCollisionEnter2D(Collision2D collision) {
		audioSrc.Play();
		if (isBreakable) {
			HandleBlockBreaking();
		}
	}

	void HandleBlockBreaking() {
		timesHit++;
		int maxHits = spriteHit.Length + 1;
		if (timesHit>=maxHits) {
			breakableBlocks--;
			DestroyObject(gameObject);
			GameObject puff = Instantiate(smoke, this.transform.position, Quaternion.identity) as GameObject;
			puff.GetComponent<ParticleSystem>().startColor = spriteRend.color;
		} else {
			spriteRend.sprite = spriteHit[timesHit - 1];
		}
	}

}
