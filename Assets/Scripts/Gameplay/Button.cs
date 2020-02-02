using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour, ITriggerable
{
    public SpriteRenderer spriteRenderer;
    public bool IsTriggered = false;
    public Color inactiveColor;
    public Color activeColor;
    public Material OnMaterial;
    public Material OffMaterial;


    private void Awake()
    {
        spriteRenderer.color = inactiveColor;
    }

    private void Update()
    {
        var newColor = IsTriggered ? activeColor : inactiveColor;
        
        if (spriteRenderer.color != newColor)
        {
            spriteRenderer.color = newColor;
        }

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
