using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

[RequireComponent(typeof(PlayerCharacterController))]
public class PlayerInputHandler : MonoBehaviour
{
    public float LookSensitivity = 1f;
    public float TriggerAxisThreshold = 0.4f;
    public bool InvertYAxisMouse = false;
    public bool InvertXAxisMouse = false;
    public bool InvertYAxisGamepad = true;
    public bool InvertXAxisGamepad = false;

    private PlayerCharacterController playerCharacterController;
    private Controls controls;
    private InputControlScheme currentControlScheme;
    private bool IsGamepad { get => controls.Player.Equals(controls.GamepadScheme); }

    public bool CanProcessInput { get => Cursor.lockState == CursorLockMode.Locked; }

    private void OnEnable()
    {
        InputUser.onChange += OnInputDeviceChanged;
        if (controls ==  null)
            controls = new Controls();
        controls.Enable();
        controls.Player.Fire.performed += Fire_performed;
        controls.Player.Jump.performed += Jump_performed;
    }

    private void OnDisable()
    {
        InputUser.onChange -= OnInputDeviceChanged;
        controls.Disable();
    }

    private void Jump_performed(InputAction.CallbackContext obj)
    {
        playerCharacterController.Jump();
    }

    private void Fire_performed(InputAction.CallbackContext obj)
    {
        playerCharacterController.Fire();
    }

    private void Start()
    {
        playerCharacterController = GetComponent<PlayerCharacterController>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void OnInputDeviceChanged(InputUser user, InputUserChange change, InputDevice device)
    {
        if (change == InputUserChange.ControlSchemeChanged)
        {
            currentControlScheme = user.controlScheme.Value;
            Debug.Log("New control scheme is'" + currentControlScheme.name + "'");
        }
    }


    public Vector3 GetMoveInput()
    {
        if (CanProcessInput)
        {
            Vector2 raw = controls.Player.Move.ReadValue<Vector2>();
            Vector3 move = new Vector3(raw.x, 0f, raw.y);
            move = Vector3.ClampMagnitude(move, 1);
            return move;
        }
        return Vector3.zero;
    }

    public Vector2 GetLookInput()
    {
        //var temp = InputUser.all[0].controlScheme.Value.Equals(controls.GamepadScheme);

        if (CanProcessInput)
        {
            Vector2 look = controls.Player.Look.ReadValue<Vector2>();
            if (IsGamepad)
            {
                if (InvertYAxisGamepad)
                    look.y *= -1;
                if (InvertXAxisGamepad)
                    look.x *= -1;
                look *= Time.deltaTime;
            }
            else
            {
                if (InvertYAxisMouse)
                    look.y *= -1;
                if (InvertXAxisMouse)
                    look.x *= -1;
            }
            look *= LookSensitivity;
            return look;
        }
        return Vector2.zero;
    }
}
