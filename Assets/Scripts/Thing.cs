using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thing : Card
{
    [SerializeField] private int minPotency;
    [SerializeField] private int maxPotency;

    public Thing(int minPotency, int maxPotency)
    {
        Potency = Random.Range(minPotency, maxPotency);
    }

    public override void Setup()
    {

    }
}
