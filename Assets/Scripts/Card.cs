using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public Tile CurrentTile;

    protected void ChangeTile(Tile targetTile)
    {
        CurrentTile = targetTile;
        transform.position = targetTile.transform.position;
    }

    protected void ResetTile()
    {

    }
}
