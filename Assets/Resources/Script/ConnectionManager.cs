using UnityEngine;
using System.Collections;
using System.Net;
using UnityEngine.UI;

public class ConnectionManager : MonoBehaviour {

	private string db_url;
	public InputField loginObj;
	public InputField passObj;
	public Text error;
	private int isLogged;
	public Text message;

	void Start () {
		isLogged = 3;
		db_url = "https://batteship-db-jrflga.c9users.io/";
	}

	void Update () {
		if (isLogged == 1)
			Application.LoadLevel (1);
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
	}

	public void Register() {
		StartCoroutine (RegisterUser ());
	}

	IEnumerator LoginUser() {
		if(!CheckConnection(db_url)) {
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
