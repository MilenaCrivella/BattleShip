using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {

	float x;
	float y;
	bool Soltar = false;
	Transform currentTarget = null;

	void Update()
	{
		x = Input.mousePosition.x;
		y = Input.mousePosition.y;
	}

	void OnMouseUp ()
	{
		if (currentTarget != null)
		{
			transform.position = currentTarget.position;
		}
	}

	void OnMouseDrag ()
	{
		transform.position = Camera.main.ScreenToWorldPoint (new Vector3 (x, y, 100.0f));
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
			if (coll.gameObject.name.Equals ("Tile_1")) {

				currentTarget = coll.transform;
			} 
	}
}
