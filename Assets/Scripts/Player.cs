using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Actor
{
    public int initialPotency; //It did not have this so I added it 

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

    public override void Setup()
    {
        Potency = initialPotency;
    }
    public void ReadInput()
    {
        foreach(var keyBinding in DirectionKeyBindings) 
        {
            if (Input.GetKeyDown(keyBinding.Value))
            {
                CardinalDirection direction = keyBinding.Key;
                Tile neighboringTile = CurrentTile.Map.GetNeighbors(CurrentTile)[direction]; 

                if (neighboringTile)
                {
                    Interact(neighboringTile);
                }
            }
        }
    }
}

