using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Actor
{
    
    private static readonly Dictionary<CardinalDirection, KeyCode> DirectionKeyBindings = 
        new Dictionary<CardinalDirection, KeyCode>()
    {
        { CardinalDirection.North, KeyCode.W },
        { CardinalDirection.East, KeyCode.D },
        { CardinalDirection.South, KeyCode.S },
        { CardinalDirection.West, KeyCode.A }
    };

    public void Update()
    {
        ReadInput();
    }

    public void ReadInput()
    {
        foreach(var keyBinding in DirectionKeyBindings) //where does keyBinding come from?
        {
            if (Input.GetKeyDown(keyBinding.Value))
            {
                CardinalDirection direction = keyBinding.Key;
                Tile neighboringTile = CurrentTile.Map.GetNeighbors(CurrentTile)[direction]; //This should be fixed if I manage to fix the Card class

                if (neighboringTile)
                {
                    ChangeTile(neighboringTile);
                }
            }
        }
    }
}

