using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour 
{
    [SerializeField] GameObject tilePrefab;

	[SerializeField] private int _rows;
	[SerializeField] private int _columns;

	[SerializeField] private Vector2 _tileOffset;
	[SerializeField] private Vector2 _initialPosition;


    public void BuildWorld()
    {
        Vector2 positionIndexer = _initialPosition;
        for (int y = 0; y < _rows; y++)
        {
            for (int x = 0; x < _columns; x++)
            {
                BuildTile(positionIndexer);

                positionIndexer.x += _tileOffset.x;
            }
            positionIndexer.y += _tileOffset.y;
            positionIndexer.x = 0;
        }
    }

	public void BuildTile (Vector2 instantiatePosition) //Vector2 position -> what was this for again?
    {
        Instantiate(tilePrefab, instantiatePosition, Quaternion.identity);
    }

}
