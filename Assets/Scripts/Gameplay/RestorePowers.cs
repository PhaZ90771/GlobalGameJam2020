﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestorePowers : MonoBehaviour
{
    public List<Button> ButtonTriggers;
    public PlayerCharacterController.ELEMENTS ElementToRestore;

    private AudioSource audioSource;
    PlayerCharacterController playerCharacterController;
    bool isUnlocked = false;

    private void Awake()
    {
        playerCharacterController = FindObjectOfType<PlayerCharacterController>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        isUnlocked = true;
        foreach (var button in ButtonTriggers)
        {
            if (!button.IsTriggered)
                isUnlocked = false;
        }
        if (isUnlocked)
            restorePower();
    }
   private void restorePower()
    {
        playerCharacterController.UnlockElement(ElementToRestore);
        audioSource.PlayOneShot(audioSource.clip);
    }
}
