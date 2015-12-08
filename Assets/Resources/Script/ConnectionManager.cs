using UnityEngine;
using System.Collections;
using System.Net;
using UnityEngine.UI;

public class ConnectionManager : MonoBehaviour {

	private string db_url;
	private int isLogged;
	public InputField loginObj;
	public InputField passObj;
	public Text error;
	public Text message;
	private Canvas gameCanvas;
	public Button loginBtn;
	public Button registerBtn;

	void Start () {
		isLogged = 3;
		db_url = "https://batteship-db-jrflga.c9users.io/";
		gameCanvas = Resources.Load ("Prefab/GameCanvas") as Canvas;
	}

	void Update () {
		if (isLogged == 1) {
			gameCanvas.planeDistance = 100;
			gameCanvas.sortingOrder = 1;
			isLogged = 3;
		}
		if (isLogged == 0)
			error.text = "Wrong login or password!";
	}

	bool CheckConnection(string URL) {
		try {
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
			request.Timeout = 5000;
			request.Credentials = CredentialCache.DefaultNetworkCredentials;
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			
			if (response.StatusCode == HttpStatusCode.OK) return true;
			else return false;
		}
		catch {
			return false;
		}
	}

	public void Connect() {
		StartCoroutine (LoginUser ());
		loginBtn.interactable = false;
		registerBtn.interactable = false;
	}

	public void Register() {
		StartCoroutine (RegisterUser ());
		loginBtn.interactable = false;
		registerBtn.interactable = false;
	}

	IEnumerator LoginUser() {
		if(!CheckConnection(db_url)) {
			Debug.Log("Oi");
			WWWForm form = new WWWForm();
			form.AddField("login", loginObj.text);
			form.AddField("pass", passObj.text);
			WWW request = new WWW(db_url + "loginManager.php", form);
			yield return request;
			isLogged = int.Parse(request.text.Split('|')[0]);
		} else {
			yield return LoginUser ();
		}
	}

	IEnumerator RegisterUser() {
		if(!CheckConnection(db_url)) {
			WWWForm form = new WWWForm();
			form.AddField("login", loginObj.text);
			form.AddField("pass", passObj.text);
			WWW request = new WWW(db_url + "registerManager.php", form);
			yield return request;
			isLogged = int.Parse(request.text.Split('|')[0]);
		} else {
			yield return RegisterUser ();
		}
	}

}
