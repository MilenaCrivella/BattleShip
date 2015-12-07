using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {

	float x;
	float y;
	bool Soltar;
	Transform currentTarget = null;

	void Update()
	{
		x = Input.mousePosition.x;
		y = Input.mousePosition.y;
	}

	void OnMouseUp ()
	{
		Soltar = true;
		if (currentTarget != null) {
			transform.position = currentTarget.position;
		}
	}

	void OnMouseDrag ()
	{
		transform.position = Camera.main.ScreenToWorldPoint (new Vector3 (x, y, 100.0f));
		Soltar = false;
	}

	void OnTriggerStay2D(Collider2D coll)
	{
		if (coll.gameObject.tag.Equals ("Tile")) {
			currentTarget = coll.transform;
		}
	}
}
