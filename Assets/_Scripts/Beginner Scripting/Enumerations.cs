using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumerations : MonoBehaviour
{

    public enum Direction { North, East, South, West };
    public Direction myDirection = Direction.North;

    // Use this for initialization
    void Start()
    {
        // Direction myDirection;
        // myDirection = Direction.North;
        Debug.Log(ReverseDirection(myDirection));
    }

    Direction ReverseDirection(Direction dir)
    {
        if (dir == Direction.North)
            dir = Direction.South;
        else if (dir == Direction.South)
            dir = Direction.North;
        else if (dir == Direction.East)
            dir = Direction.West;
        else if (dir == Direction.West)
            dir = Direction.East;
        return dir;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
