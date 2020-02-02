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

    PlayerCharacterController playerCharacterController;

    private void Awake()
    {
        playerCharacterController = FindObjectOfType<PlayerCharacterController>();
    }

    void Update()
    {
        Air.enabled = playerCharacterController.HasElement(PlayerCharacterController.ELEMENTS.AIR);
        Fire.enabled = playerCharacterController.HasElement(PlayerCharacterController.ELEMENTS.FIRE);
        Earth.enabled = playerCharacterController.HasElement(PlayerCharacterController.ELEMENTS.EARTH);
        Water.enabled = playerCharacterController.HasElement(PlayerCharacterController.ELEMENTS.WATER);
    }
}
