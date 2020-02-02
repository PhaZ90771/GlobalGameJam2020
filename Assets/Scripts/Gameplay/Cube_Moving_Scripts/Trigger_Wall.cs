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

    public void Trigger(float distance, List<PlayerCharacterController.ELEMENTS> playersElements)
    {
        if (playersElements.Contains(GetRequiredElement()))
            cube_Behavior.MoveCube(Direction);
    }

    public bool InRange(float distance, List<PlayerCharacterController.ELEMENTS> playersElements)
    {
        return playersElements.Contains(GetRequiredElement());
    }

    public PlayerCharacterController.ELEMENTS GetRequiredElement() => PlayerCharacterController.ELEMENTS.AIR;
}
