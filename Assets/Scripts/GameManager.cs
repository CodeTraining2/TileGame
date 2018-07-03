﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour 
{
	[SerializeField] private WorldManager _worldManager;

    public void Start()
    {
        _worldManager.BuildWorld();
    }
}
