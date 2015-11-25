using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

	public GameObject Quadrado;
	int linhas = 5;
	int colunas = 5;

	void Start()
	{
		Instanciar (linhas, colunas);
	}

	void Instanciar(int L, int C)
	{
		for (int i = 0; i < C; i++) 
		{
			for(int n = 0; n < L; n++)
			{
				Quadrado.transform.position = new Vector3((-10f + 1.85f*i),0, -10f - 1.85f*n);
				Instantiate(Quadrado);
			}
		}
	}

	void OnMouseDown()
	{
		Debug.Log ("ooi");
		Destroy (GameObject.FindGameObjectWithTag("Quadrado").gameObject);
	}

}
