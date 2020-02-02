using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITriggerable
{
    bool InRange(float distance);
    void Trigger(float distance);
}
