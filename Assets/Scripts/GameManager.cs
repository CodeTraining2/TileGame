using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour 
{
	[SerializeField] private WorldManager _worldManager;
    [SerializeField] private CardManager _cardManager;

    public void Start()
    {
        _worldManager.BuildWorld();
        
    }
}
