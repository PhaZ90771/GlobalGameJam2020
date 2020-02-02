using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class CrosshairUI : MonoBehaviour
{
    public Image ElementTooltip;
    public ElementsTooltipUI ElementsTooltipUI;
    public Image ControlTooltip;

    public enum CROSSHAIR_STATES {
        YES,
        NO,
        MAYBE
    }

    Image crosshair;

    public CROSSHAIR_STATES CrosshairState = CROSSHAIR_STATES.NO;
    public PlayerCharacterController.ELEMENTS NeededElement;

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
            crosshair.enabled = NeededElement == PlayerCharacterController.ELEMENTS.NULL;
            ControlTooltip.enabled = true;
            ElementTooltip.enabled = NeededElement != PlayerCharacterController.ELEMENTS.NULL ? true : false;
            ElementsTooltipUI.NeededElement = NeededElement;
            break;
            case CROSSHAIR_STATES.NO:
            crosshair.enabled = true;
            newCrosshair = GeneralCrosshair;
            ElementTooltip.enabled = false;
            break;
            case CROSSHAIR_STATES.MAYBE:
            crosshair.enabled = true;
            newCrosshair = PossibleCrosshair;
            ElementTooltip.enabled = NeededElement != PlayerCharacterController.ELEMENTS.NULL ? true : false;
            ElementsTooltipUI.NeededElement = NeededElement;
            break;
        }

        if (!crosshair.sprite.Equals(newCrosshair))
            crosshair.sprite = newCrosshair;
    }
}
