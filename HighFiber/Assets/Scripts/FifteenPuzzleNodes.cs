using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FifteenPuzzleNodes : Interractable
{
    public int[] location;
    [SerializeField]private FifteenPuzzle _fifteenPuzzle;

    public override void OnPlayerInterract()
    {
        _fifteenPuzzle.CheckAvailability(gameObject, location);
    }
}