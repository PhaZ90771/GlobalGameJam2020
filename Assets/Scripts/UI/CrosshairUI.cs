using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class CrosshairUI : MonoBehaviour
{
    public enum CROSSHAIR_STATES {
        YES,
        NO,
        MAYBE
    }

    Image crosshair;

    public CROSSHAIR_STATES CrosshairState = CROSSHAIR_STATES.NO;

    public Sprite GeneralCrosshair;
    public Sprite InteractableCrosshair;
    public Sprite PossibleCrosshair;

    private void Awake()
    {
        crosshair = GetComponent<Image>();
    }

    private void Update()
    {
        var newCrosshair = GeneralCrosshair;

        switch (CrosshairState)
        {
            case CROSSHAIR_STATES.YES:
            newCrosshair = InteractableCrosshair;
            break;
            case CROSSHAIR_STATES.NO:
            newCrosshair = GeneralCrosshair;
            break;
            case CROSSHAIR_STATES.MAYBE:
            newCrosshair = PossibleCrosshair;
            break;
        }

        if (!crosshair.sprite.Equals(newCrosshair))
            crosshair.sprite = newCrosshair;
    }
}
