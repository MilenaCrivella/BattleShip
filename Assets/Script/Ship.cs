using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {

	float x;
	float y;

	void Update()
	{
		x = Input.mousePosition.x;
		y = Input.mousePosition.y;

	}

	void OnMouseDrag ()
	{
		transform.position = Camera.main.ScreenToWorldPoint (new Vector3 (x, y, 100.0f));
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.name.Equals("Tile_1_1"))
		{
			Debug.Log("ok");
		}
	}
}
