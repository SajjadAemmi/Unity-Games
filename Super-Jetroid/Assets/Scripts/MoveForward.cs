using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

	public float speed = .9f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2 (transform.localScale.x, 0) * speed;
	}
}
