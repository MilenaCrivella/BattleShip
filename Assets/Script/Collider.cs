using UnityEngine;
using System.Collections;

public class Collider : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter (Collider button) {
		if (button.gameObject.tag == "Button") {
			Debug.Log ("colidiu");
		}
	}

}
