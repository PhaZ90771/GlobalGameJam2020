using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class CrosshairUI : MonoBehaviour
{
    Image crosshair;

    public bool IsInteractable = false;

    public Sprite GeneralCrosshair;
    public Sprite InteractableCrosshair;

    private void Awake()
    {
        crosshair = GetComponent<Image>();
    }

    private void Update()
    {
        var newCrosshair = IsInteractable ? InteractableCrosshair : GeneralCrosshair;
        if (!crosshair.sprite.Equals(newCrosshair))
            crosshair.sprite = newCrosshair;
    }
}
