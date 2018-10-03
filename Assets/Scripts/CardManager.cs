using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    [SerializeField] private int _playerSpawnX;
    [SerializeField] private int _playerSpawnY;
    [SerializeField] private Player _playerPrefab;
    [SerializeField] private int _initialPlayerPotency = 10;
    [SerializeField] private bool isPlayer;

    public void SpawnPlayer(Map map)
    {

        Tile tile = map.GetTileByCoordinates(_playerSpawnX, _playerSpawnY);
        SetupPlayer(tile);
    }

    private void SetupCard(Card card, Map map, int x, int y)
    {
        _player.CurrentTile = tile;
        _player.transform.position = tile.transform.position;
        _player = Instantiate(_playerPrefab); // 3. c. iii.
        tile.CurrentCard = _player;
    }

    public void SpawnCard(Map map, Coordinates coordinates,bool isPlayer)
    {
        Card prefab;
        if(isPlayer == true)
        {
            prefab = _thingPrefab;
            Instantiate(Thing, /*SomePosition*/); <-------------------3. d. iii.
        }
        else
        {
            prefab = _playerPrefab;
            Instantiate(Player, /*SomePosition*/); <-------------------3. d. iii.
        }

        SetupCard(Card prefab, Map map,)

    }
}

