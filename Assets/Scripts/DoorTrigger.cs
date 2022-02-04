using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {

	public Door door;
	public bool ignoreTrigger;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D target){

		if (ignoreTrigger)
			return;

		if (target.gameObject.tag == "Player") {
			door.Open();
		}
	}

	void OnTriggerExit2D(Collider2D target){
		if (ignoreTrigger)
			return;

		if (target.gameObject.tag == "Player") {
			door.Close();
		}
	}

	public void Toggle(bool value){
		if (value)
			door.Open ();
		else
			door.Close ();
	}

	void OnDrawGizmos(){
		Gizmos.color = ignoreTrigger ? Color.gray : Color.green;

		var bc2d = GetComponent<BoxCollider2D> ();
		var bc2dPOS = bc2d.transform.position;
		var newPos = new Vector2 (bc2dPOS.x + bc2d.offset.x, bc2dPOS.y + bc2d.offset.y);

		Gizmos.DrawWireCube (newPos, new Vector2 (bc2d.size.x, bc2d.size.y));

	}

}
