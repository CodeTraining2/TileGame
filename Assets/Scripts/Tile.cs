using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {
    public TextMesh TextMesh;
    public Card CurrentCard;
    public Map Map;
    public Coordinates Coordinates;
    

    public int X
    {
        get { return Coordinates.X; }
    }

    public int Y
    {
        get { return Coordinates.Y; }
    }

}
