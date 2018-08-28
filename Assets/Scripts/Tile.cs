using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {
    public TextMesh TextMesh;
    public Node Node;
    public Card Card;
    public Card CurrentCard;
    public Map Map;
    

    public int X
    {
        get { return Node.X; }
    }

    public int Y
    {
        get { return Node.Y; }
    }

}
