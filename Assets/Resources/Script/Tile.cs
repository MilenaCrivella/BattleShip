using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {
	
	public Vector2 gridPos;
	public GameObject gameManager;

	//Colors
	private Color32 gruvGray = new Color32(168, 153, 132, 255);

	void Start() {
		gameManager = GameObject.Find ("GameManager");
	}

	void OnMouseDown() {
		if(Input.GetKey(KeyCode.Mouse0)) {
			if(gameManager.GetComponent<GameManager>().currentState == "ship1_selection") {
				this.gameObject.GetComponent<SpriteRenderer>().color = gruvGray;
				gameManager.GetComponent<GameManager>().ship1CoordsX = (int)gridPos.x;
				gameManager.GetComponent<GameManager>().ship1CoordsY = (int)gridPos.y;

				if(gridPos.x == gameManager.GetComponent<GameManager>().ship1CoordsX - 1 ||
				   gridPos.x == gameManager.GetComponent<GameManager>().ship1CoordsX + 1 ||
				   gridPos.y == gameManager.GetComponent<GameManager>().ship1CoordsY - 1 ||
				   gridPos.y == gameManager.GetComponent<GameManager>().ship1CoordsY + 1) {
					this.gameObject.GetComponent<SpriteRenderer>().color = gruvGray;
				} else {
					Debug.Log("Nao pode");
				}
			}
		}
	}
}
