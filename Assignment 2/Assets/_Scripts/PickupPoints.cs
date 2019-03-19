using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupPoints : MonoBehaviour // Unity properties
{
    private int points;

    public int Points
    {
        get
        {
            return points;
        }
        set
        {
            points = value;
        }
    }
}
