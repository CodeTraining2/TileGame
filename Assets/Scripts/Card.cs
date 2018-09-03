using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public Tile CurrentTile;
    private Card _currentCard; //I did not have CurrentCard in here, which you wanted me to make private (did you mean current tile?) 4.a
   [SerializeField] private int Potency;

    private void ChangeTile(Tile targetTile)
    {
        CurrentTile = targetTile;
        transform.position = targetTile.transform.position;
    }

    protected void ResetTile()
    {

    }

    public int CurrentCard
    {
        get
        {
            return _currentCard;
        }
        set
        {
            _currentCard = value; //what? 4.b
            _currentCard.CurrentTile = CurrentTile; //??? 4.b
        }
    }

    public void Interact(Tile tile)
    {
        if (CurrentTile.Card != null)
        {
            Card.Potency += _currentCard.Potency; //4.e
            DestroyCard();
        }
        ChangeTile();
        CurrentTile.Card = null;
    }

    private void DestroyCard()
    {
        Card.CurrentTile = null;
        Destroy(gameObject);
    }
}
