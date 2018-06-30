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
        BuildTile();
    }

	public void BuildTile () //Vector2 position -> what was this for again?
    {
        for (int y = 0; y < _rows; y++)
        {
            for (int x = 0; x < _columns; x++)
            {
                Instantiate(tilePrefab, _initialPosition, Quaternion.identity);
                _initialPosition.x += _tileOffset.x;
            }
            _initialPosition.y += _tileOffset.y;
            _initialPosition.x = 0;
        }
	}

}
