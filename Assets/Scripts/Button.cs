using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour, ITriggerable
{
    public bool IsTriggered = false;

    public void Trigger(float distance)
    {
        IsTriggered = distance <= 2f ? !IsTriggered : IsTriggered;
    }
}
