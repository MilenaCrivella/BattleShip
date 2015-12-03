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
		GameObject outro = GameObject.Find("Outro");
		Grid grid = outro.GetComponent<Grid> ();
		
		
		if (!clicked && grid.navios > 0) {
			
			clicked = true;
			this.gameObject.GetComponent<Image> ().color = Color.red;
			grid.navios -= 1;
			Debug.Log(grid.navios);
			
		} else if (clicked) {
			
			clicked = false;
			this.gameObject.GetComponent<Image> ().color = Color.white;
			grid.navios += 1;
			
		}
	}
}
