using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ControlsUI : MonoBehaviour
{
    Image image;
    PlayerInputHandler playerInputHandler;

    public Sprite KeyboardMouseSprite;
    public Sprite GamepadSprite;

    private void Awake()
    {
        image = GetComponent<Image>();
        playerInputHandler = FindObjectOfType<PlayerInputHandler>();
    }

    void Update()
    {
        var newSprite = playerInputHandler.CurrentControlMode == PlayerInputHandler.CONTROL_MODE.GAMEPAD ? GamepadSprite : KeyboardMouseSprite;
        if (!image.sprite.Equals(newSprite))
            image.sprite = newSprite;
    }
}
