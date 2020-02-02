using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public List<Button> Buttons;
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
}
