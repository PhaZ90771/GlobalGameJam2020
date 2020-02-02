﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITriggerable
{
    bool InRange(float distance, List<PlayerCharacterController.ELEMENTS> playersElements);
    void Trigger(float distance, List<PlayerCharacterController.ELEMENTS> playersElements);
}
