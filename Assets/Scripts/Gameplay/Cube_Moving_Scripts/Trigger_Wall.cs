using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Wall : MonoBehaviour, ITriggerable
{
    public Cube_Behavior.Direction Direction;

    private Cube_Behavior cube_Behavior;

    private void Awake()
    {
        cube_Behavior = GetComponentInParent<Cube_Behavior>();
    }

    public void Trigger(float distance)
    {
        cube_Behavior.MoveCube(Direction);
    }

    public bool InRange(float distance)
    {
        return true;
    }
}
