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
		//GameObject outro = GameObject.Find("Outro");
		//Grid grid = outro.GetComponent<Grid> ();

			if (!clicked) {
				this.gameObject.GetComponent<Image> ().color = Color.red;
			} 

	}
}
