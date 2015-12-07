using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MouseClick : MonoBehaviour {

	private bool clicked;
	void Start () 
	{
		clicked = false;
	}
	
	public void ChangeColor()
	{
		if (!clicked) {
			if(gameObject.name.Equals("Tile_2")) {
				this.gameObject.GetComponent<Image> ().color = Color.red;
			}
		} 
	}
	
	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.name.Equals ("Ship1")) {
			this.gameObject.GetComponent<Image> ().color = Color.gray;
		} 
	}

	void OnTriggerExit2D(Collider2D coll)
	{
		if (coll.gameObject.name.Equals ("Ship1")) {
			this.gameObject.GetComponent<Image> ().color = Color.white;
		} 
	}
}
