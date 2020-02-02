using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElementsUI : MonoBehaviour
{
    public Image Air;
    public Image Fire;
    public Image Earth;
    public Image Water;

    public Color AirColor;
    public Color FireColor;
    public Color EarthColor;
    public Color WaterColor;
    public Color DisableColor;

    PlayerCharacterController playerCharacterController;

    private void Awake()
    {
        playerCharacterController = FindObjectOfType<PlayerCharacterController>();
    }

    void Update()
    {
        Air.color = playerCharacterController.HasElement(PlayerCharacterController.ELEMENTS.AIR) ? AirColor : DisableColor;
        Fire.color = playerCharacterController.HasElement(PlayerCharacterController.ELEMENTS.FIRE) ? FireColor : DisableColor;
        Earth.color = playerCharacterController.HasElement(PlayerCharacterController.ELEMENTS.EARTH) ? EarthColor : DisableColor;
        Water.color = playerCharacterController.HasElement(PlayerCharacterController.ELEMENTS.WATER) ? WaterColor : DisableColor;
    }
}
