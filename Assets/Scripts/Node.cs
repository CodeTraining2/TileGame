using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    private readonly Coordinates _coordinates;

    public int X
    {
        get { return _coordinates.X; }
    }

    public int Y
    {
        get { return _coordinates.Y; }
    }

    public Node(Coordinates coordinates)
    {
        _coordinates = coordinates;
    }
}
