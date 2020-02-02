using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestorePowers : MonoBehaviour
{
    public List<Button> buttons;
    public PlayerCharacterController.ELEMENTS elements;
    public PlayerCharacterController playerCharacterController;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isUnlocked = false;
        foreach (var button in buttons)
        {
            if (!button.IsTriggered)
                isUnlocked = false;
        }
        if (isUnlocked)
            restorePower();
    }
   private void restorePower()
    {
        playerCharacterController.UnlockElement(elements);
    }
}
