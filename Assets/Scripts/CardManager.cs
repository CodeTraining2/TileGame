using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    [SerializeField] private int _playerSpawnX;
    [SerializeField] private int _playerSpawnY;
    [SerializeField] private Player _playerPrefab;
    [SerializeField] private int _initialPlayerPotency = 10;
    private Player _player;

    public void SpawnPlayer(Map map)
    {
        _player = Instantiate(_playerPrefab);
        Tile tile = map.GetTileByCoordinates(_playerSpawnX, _playerSpawnY);
        SetupPlayer(tile);
    }

    private void SetupPlayer(Tile tile)
    {
        _player.Potency = _initialPlayerPotency;
        _player.CurrentTile = tile;
        _player.transform.position = tile.transform.position;

        tile.CurrentCard = _player;
    }
}
