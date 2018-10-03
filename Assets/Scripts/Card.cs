using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card : MonoBehaviour
{
    private Tile _currentTile;
    public int Potency;



    protected void ResetTile()
    {

    }

    public Tile CurrentTile
    {
        get
        {
            return _currentTile;
        }
        set
        {
            _currentTile = value;
            if (value.CurrentCard != null)
            {
                _currentTile.CurrentCard = this;
            }
        }
    }

    public abstract void Setup();

    public void Interact(Tile targetTile)
    {
        if (targetTile.CurrentCard != null)
        {
            Potency += targetTile.CurrentCard.Potency;
            DestroyCard();
        }
        ChangeTile(targetTile);
    }

    private void ChangeTile(Tile targetTile)
    {
        _currentTile = targetTile;
        transform.position = targetTile.transform.position;
        _currentTile.CurrentCard = null;
    }

    private void DestroyCard()
    {
        Destroy(gameObject);
    }
}
