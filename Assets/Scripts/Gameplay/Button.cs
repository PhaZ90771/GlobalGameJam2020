﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour, ITriggerable
{
    public bool IsTriggered = false;
    public Material OnMaterial;
    public Material OffMaterial;

    private Renderer rend;

    private void Awake()
    {
        rend = GetComponent<Renderer>();
        rend.material = OffMaterial;
    }

    private void Update()
    {
        var newMaterial = IsTriggered ? OnMaterial : OffMaterial;

        if (rend.material != newMaterial)
            rend.material = newMaterial;
    }

    public void Trigger(float distance, List<PlayerCharacterController.ELEMENTS> playersElements)
    {
        IsTriggered = distance <= 5f && playersElements.Contains(GetRequiredElement()) ? !IsTriggered : IsTriggered;
    }

    public bool InRange(float distance, List<PlayerCharacterController.ELEMENTS> playersElements)
    {
        return distance <= 5f && playersElements.Contains(GetRequiredElement());
    }

    public PlayerCharacterController.ELEMENTS GetRequiredElement() => PlayerCharacterController.ELEMENTS.NULL;
}
