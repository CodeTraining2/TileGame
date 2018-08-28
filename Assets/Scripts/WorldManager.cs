using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour 
{
    [SerializeField] Tile tilePrefab;

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

    public void PopulateMap()
    {
        Vector2 positionIndexer = _initialPosition;
        for (int y = 0; y < _rows; y++)
        {
            for (int x = 0; x < _columns; x++)
            {
                Coordinates newCoordinates = new Coordinates(x, y);

                BuildTile(positionIndexer, newCoordinates);

                positionIndexer.x += _tileOffset.x;
            }
            positionIndexer.y += _tileOffset.y;
            positionIndexer.x = 0;
        }
    }

	public void BuildTile (Vector2 instantiatePosition, Coordinates newCoordinates)
    {
        Tile tile = Instantiate(tilePrefab, instantiatePosition, Quaternion.identity);
        tile.TextMesh.text = "[" + newCoordinates.X + "," + newCoordinates.Y + "]";
        tile.Map = Map;
        AddNodeToMap(tile, newCoordinates);
        tile.Node = new Node(newCoordinates);
        
    }

    public void AddNodeToMap(Tile tile, Coordinates newNodeCoordinates)
    {
        var node = new Node(newNodeCoordinates);
        Map.AddNode(tile);
    }

}


