using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardinalDirection
{
    North,
    East,
    South,
    West
}

public class Map
{
    List<Tile> _map = new List<Tile>();


    public static Dictionary<CardinalDirection, Coordinates> Directions = new Dictionary<CardinalDirection, Coordinates>()
    {
        { CardinalDirection.North, new Coordinates(0, 1) },
        { CardinalDirection.East, new Coordinates(1, 0) },
        { CardinalDirection.South, new Coordinates(0, -1) },
        { CardinalDirection.West, new Coordinates(-1, 0) }
    };

    public Tile GetTileByCoordinates(Coordinates coordinates)
    {
        foreach (Tile tile in _map)
        {
            if (tile.Coordinates.X == coordinates.X && tile.Coordinates.Y == coordinates.Y)
            {
                return tile;
            }
        }

        return null;
    }

    public Dictionary<CardinalDirection, Tile> GetNeighbors(Tile tile)
    {
        Dictionary<CardinalDirection, Tile> neighborsCollection = new Dictionary<CardinalDirection, Tile>();

        foreach (var direction in Directions)
        {
            int targetX = direction.Value.X + tile.Coordinates.X;
            int targetY = direction.Value.Y + tile.Coordinates.Y;
            var targetCoordinates = new Coordinates(targetX, targetY);
            Tile neighbor = GetTileByCoordinates(targetCoordinates.X, targetCoordinates.Y); //I don't get why this doesn't work, as targetCoordinates still contains x and y?

            if (neighbor != null)
            {
                neighborsCollection.Add(direction.Key, neighbor);
                Debug.Log("Neighbor " + neighbor.X + " " + neighbor.Y + " Has been added");
            }
        }

        return neighborsCollection;
    }

    public void AddTile(Tile tile)
    {
        _map.Add(tile);
    }
}
