using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    [SerializeField] private Player _playerPrefab;
    [SerializeField] private Thing _thingPrefab;

    public void SpawnCard(Map map, Coordinates spawnCoordinates, bool isPlayer = false)
    {
        Card prefab;
        if (isPlayer)
        {
            prefab = _playerPrefab;
        }
        else
        {
            prefab = _thingPrefab;
        }

        var card = Instantiate(prefab);
        SetupCard(card, map, spawnCoordinates);
    }

    public void SetupCard(Card card, Map map, Coordinates spawnCoordinates)
    {
        Tile spawnTile = map.GetTileByCoordinates(spawnCoordinates);
        card.CurrentTile = spawnTile;
        card.transform.position = spawnTile.transform.position;
        card.Setup();
    }
}

