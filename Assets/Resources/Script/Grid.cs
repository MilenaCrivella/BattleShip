using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Grid : MonoBehaviour {

	public GameObject Tile;
	public GameObject canvas;
	private GameObject instTile;
	int number = 0;
	int type = 1;

	void Start()
	{
		Instanciar (5, 5, 4 - 1.65f, 4 - 1.65f);
		Instanciar (5, 5, 200, 4 - 1.65f);
	}
	
	void Instanciar(int L, int C, float point_x, float point_y)
	{
		for (int i = 0; i < C; i++) 
		{
			for(int n = 0; n < L; n++)
			{
				Tile.transform.position = new Vector2((point_x + i * 33),point_y + n * 31);
				Tile.SetActive(true);
				instTile = Instantiate(Tile) as GameObject;
				instTile.transform.SetParent(canvas.transform, false);
				number++;
				instTile.name = "Tile" + "_" + type;

				if(number >= 25)
				{
					number = 0;
					type = 2;
				}

			}
		}
	}
}
