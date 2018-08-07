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


    private static Dictionary<CardinalDirection, Coordinates> _directions = new Dictionary<CardinalDirection, Coordinates>()
    {
        { CardinalDirection.North, new Coordinates(0, 1) },
        { CardinalDirection.East, new Coordinates(1, 0) },
        { CardinalDirection.South, new Coordinates(0, -1) },
        { CardinalDirection.West, new Coordinates(-1, 0) }
    };

    public Tile GetTileByCoordinates(int x, int y)
    {
        foreach (Tile tile in _map)
        {
            if (tile.X == x && tile.Y == y)
            {
                return tile;
            }
        }

        return null;
    }

    public List<Tile> GetNeighbours(Tile tile)
    {
        List<Tile> neighbours = new List<Tile>();

        foreach (var direction in _directions.Values)
        {
            int neighbourX = tile.X + direction.X;
            int neighbourY = tile.Y + direction.Y;
            Tile neighbour = GetTileByCoordinates(neighbourX, neighbourY);

            if (neighbour != null)
            {
                neighbours.Add(neighbour);
                Debug.Log("Neighbour " + neighbour.X + " " + neighbour.Y + " Has been added");
            }
        }

        return neighbours;
    }

    public void AddNode(Tile tile)
    {
        _map.Add(tile);
    }
}
