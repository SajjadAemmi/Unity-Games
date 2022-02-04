using UnityEngine;
using System.Collections;

public class FloatEffect : MonoBehaviour {

	private float startY;
	private float duration = 1f;

	// Use this for initialization
	void Start () {
		startY = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		float newY = startY + (startY + Mathf.Cos (Time.time / duration * 2)) / 4;
		transform.position = new Vector3 (transform.position.x, newY, transform.position.z);
	}
}
