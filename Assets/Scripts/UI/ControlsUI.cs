using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ControlsUI : MonoBehaviour
{
    Image image;
    PlayerInputHandler playerInputHandler;
    ControllerUIButtonShim controllerUIButtonShim;

    public Sprite KeyboardMouseSprite;
    public Sprite GamepadSprite;

    private void Awake()
    {
        image = GetComponent<Image>();
        playerInputHandler = FindObjectOfType<PlayerInputHandler>();
        controllerUIButtonShim = FindObjectOfType<ControllerUIButtonShim>();
    }

    void Update()
    {
        var inputMode = playerInputHandler != null ? playerInputHandler.CurrentControlMode : controllerUIButtonShim.CurrentControlMode;
        var newSprite = inputMode == PlayerInputHandler.CONTROL_MODE.GAMEPAD ? GamepadSprite : KeyboardMouseSprite;
        if (!image.sprite.Equals(newSprite))
            image.sprite = newSprite;
    }
}
