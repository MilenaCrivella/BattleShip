using UnityEngine;
using System.Collections;

public class Helper : MonoBehaviour {

	void Update () {
		transform.position = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 100.0f));
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.name.Equals ("Tile_1")) {

		}
	}
}
