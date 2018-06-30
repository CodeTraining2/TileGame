using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour 
{
	public WorldManager worldManager;

    public void Start()
    {
        worldManager.BuildWorld();
    }
}
