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

    public Map Map;


    public void BuildWorld()
    {
        Map = new Map();
        PopulateMap();
    }

	public void BuildTile (Vector2 instantiatePosition) //Vector2 position -> what was this for again?
    {

        // What is meant by "Add x and y parameters to BuildTile()"
        Instantiate(tilePrefab, instantiatePosition, Quaternion.identity);
    }

    public void PopulateMap()
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

    public void AddNode(int x, int y)
    {
        var node = new Node(x, y);
        Map.AddNode(node);
    }

}


// I can't add a textmesh because it conflicts with the meshfilter, which if removed makes the whole thing invisible

