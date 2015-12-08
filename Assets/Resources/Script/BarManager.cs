using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class BarManager : MonoBehaviour {

	public Text clockText;
	public Text calendarText;
	public Text soundText;

	void Update () {
		UpdateClock ();
		UpdateCalendar ();
	}


	public void UpdateClock() {
		clockText.text = DateTime.Now.ToString ("HH:mm");
	}

	public void UpdateCalendar() {
		calendarText.text = DateTime.Now.ToString ("MMM dd");
	}

	public void Exit() {
		Application.Quit();
		UnityEditor.EditorApplication.isPlaying = false;
	}
}
