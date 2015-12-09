using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	public string currentState;
	private string[] currentStates = {
		"ship1_selection",
		"ship2_selection",
		"player1_decision",
		"player1_decision"
	};

	public int ship1Amount;
	public int ship2Amount;

	public int ship1CoordsX, ship1CoordsY;
	public int ship2CoordsX, ship2CoordsY;

	void Start () {
		currentState = currentStates[0];
	}

	void Update () {
	
	}
}
