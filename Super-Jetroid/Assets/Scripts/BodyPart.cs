using UnityEngine;
using System.Collections;

public class BodyPart : MonoBehaviour {

	private SpriteRenderer spriteRenderer;
	private Color start;
	private Color end;
	private float t = 0.0f;

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer> ();
		start = spriteRenderer.color;
		end = new Color (start.r, start.g, start.b, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		t += Time.deltaTime;

		GetComponent<Renderer>().material.color = Color.Lerp (start, end, t / 2);

		if (GetComponent<Renderer>().material.color.a <= 0.0)
			Destroy (gameObject);
	}
}
