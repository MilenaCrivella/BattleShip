using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MouseClick : MonoBehaviour {

	private Color32 gruvGray;
	private Color32 gruvBlue;
	private Vector3 centerTile;

	private bool clicked;
	void Start () {
		gruvGray = new Color32 (166, 151, 131, 255);
		gruvBlue = new Color32 (129, 163, 152, 255);
		clicked = false;
		Screen.showCursor = false;
		centerTile = new Vector3 (this.gameObject.transform.position.x / 2, 
		                          this.gameObject.transform.position.y / 2,
		                          this.gameObject.transform.position.z);
	}
	
	public void ChangeColor() {
		if (!clicked) {
			if(gameObject.tag.Equals("Tile")) {
				this.gameObject.GetComponent<Image> ().color = Color.white;
			}
		} 
	}
	
	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag.Equals ("Ship")) {
			this.gameObject.GetComponent<Image> ().color = gruvGray;
			coll.transform.position = centerTile;
		} 
	}

	void OnTriggerExit2D(Collider2D coll) {
		if (coll.gameObject.tag.Equals ("Ship")) {
			this.gameObject.GetComponent<Image> ().color = gruvBlue;
		} 
	}
}
