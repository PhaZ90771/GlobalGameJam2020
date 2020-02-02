using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ControllerUIButtonShim : MonoBehaviour
{
    public PlayerInputHandler.CONTROL_MODE CurrentControlMode = PlayerInputHandler.CONTROL_MODE.KEYBOARDMOUSE;

    public Controls Controls;
    public Selectable FirstSelected;

    private List<UnityEngine.UI.Button> buttons = new List<UnityEngine.UI.Button>();
    private Selectable selected;

    void OnEnable()
    {
        if (Controls == null)
            Controls = new Controls();
        Controls.Enable();
        Controls.Player.Move.started += MoveLook_Started;
        Controls.Player.Look.started += MoveLook_Started;
    }

    private void Awake()
    {
        selected = FirstSelected;
    }

    private void Start()
    {
        selected.Select();
        EventSystem.current.SetSelectedGameObject(selected.gameObject);
    }

    private void MoveLook_Started(InputAction.CallbackContext obj)
    {
        CurrentControlMode = obj.control.device.name.Equals("Mouse") ? PlayerInputHandler.CONTROL_MODE.KEYBOARDMOUSE : PlayerInputHandler.CONTROL_MODE.GAMEPAD;

        Cursor.lockState = CurrentControlMode == PlayerInputHandler.CONTROL_MODE.GAMEPAD ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible = CurrentControlMode == PlayerInputHandler.CONTROL_MODE.GAMEPAD ? false : true;
    }
}
