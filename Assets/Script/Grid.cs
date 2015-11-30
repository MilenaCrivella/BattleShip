using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

	public GameObject Quadrado;

	void Start()
	{
		Instanciar (5, 5, 4 - 1.65f, 4 - 1.65f);
		Instanciar (5, 5, -13 - 50, 4 - 1.65f);
	}

	void Instanciar(int L, int C, float point_x, float point_y)
	{
		for (int i = 0; i < C; i++) 
		{
			for(int n = 0; n < L; n++)
			{
				Quadrado.transform.position = new Vector3((point_x * i),0, point_y * n);
				Instantiate(Quadrado);
			}
		}
	}

}
