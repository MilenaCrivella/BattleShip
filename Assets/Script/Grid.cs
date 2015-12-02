using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

	public GameObject Tile;
	public GameObject canvas;
	
	void Start()
	{
		Instanciar (5, 5, 4 - 1.65f, 4 - 1.65f);
		Instanciar (5, 5, 2900, 4 - 1.65f);
	}
	
	void Instanciar(int L, int C, float point_x, float point_y)
	{
		for (int i = 0; i < C; i++) 
		{
			for(int n = 0; n < L; n++)
			{
				Tile.transform.position = new Vector2((point_x + i * 480),point_y + n * 82);
				Tile.SetActive(true);
				var instTile = Instantiate(Tile) as GameObject;
				instTile.transform.SetParent(canvas.transform, false);
			}
		}
	}
}
