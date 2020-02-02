using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour, ITriggerable
{
    public List<Button> Buttons;
    public List<Target_Location> target_Locations;
    public Material OnMaterial;
    public Material OffMaterial;

    public string GotoScene = "";

    private Renderer rend;

    private bool IsTriggered = false;

    private void Awake()
    {
        rend = GetComponent<Renderer>();
        rend.material = OffMaterial;
    }

    private void Update()
    {
        IsTriggered = true;
        foreach (var button in Buttons)
        {
            if (!button.IsTriggered)
                IsTriggered = false;
        }
        foreach (var target_Location in target_Locations)
        {
            if (!target_Location.trigger)
                IsTriggered = false;
        }

        var newMaterial = IsTriggered ? OnMaterial : OffMaterial;

        if (rend.material != newMaterial)
            rend.material = newMaterial;
    }

    public void Open()
    {
        if (IsTriggered)
        {
            SceneManager.LoadScene(GotoScene);
        }
    }

    public bool InRange(float distance, List<PlayerCharacterController.ELEMENTS> playersElements)
    {
        return distance < 5f && IsTriggered && playersElements.Contains(GetRequiredElement());
    }

    public void Trigger(float distance, List<PlayerCharacterController.ELEMENTS> playersElements)
    {
        if (distance < 5f && IsTriggered && playersElements.Contains(GetRequiredElement()))
        {
            Open();
        }
    }

    public PlayerCharacterController.ELEMENTS GetRequiredElement() => PlayerCharacterController.ELEMENTS.NULL;
}
