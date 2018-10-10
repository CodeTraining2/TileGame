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

    [SerializeField] private CardManager _cardManager;

    public Map Map;

    [SerializeField] private int _playerInitialX = 0;
    [SerializeField] private int _playerInitialY = 0;

    [Range(0,1)] [SerializeField] private float _thingSpawnPropability;

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
                populateTile(newCoordinates); // 4. b. v.
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
        tile.Coordinates = newCoordinates;
        
    }

    private void populateTile(Coordinates coordinates)
    {
        var isPlayer = _playerInitialX == coordinates.X && _playerInitialY == coordinates.Y;
        var shouldSpawnThing = Random.Range(0f, 1f) < _thingSpawnPropability;
            if (isPlayer || shouldSpawnThing)
            {
                _cardManager.SpawnCard(Map, coordinates, isPlayer);
            }
        
    }
}


