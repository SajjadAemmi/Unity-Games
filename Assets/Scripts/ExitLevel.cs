using UnityEngine;
using System.Collections;

public class ExitLevel : MonoBehaviour {

	public string scene;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D target){
		if (target.gameObject.tag == "Player") {
			Destroy(target.gameObject);
			Application.LoadLevel(scene);
		}
	}
}
