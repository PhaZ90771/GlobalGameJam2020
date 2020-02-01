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
    public bool InvertYAxis = false;
    public bool InvertXAxis = false;

    private PlayerCharacterController playerCharacterController;
    private Controls controls;
    private InputControlScheme currentControlScheme;
    private bool IsGamepad { get => currentControlScheme.Equals(controls.GamepadScheme); }

    public bool CanProcessInput { get => Cursor.lockState == CursorLockMode.Locked; }

    private void OnEnable()
    {
        InputUser.onChange += OnInputDeviceChanged;
        if (controls ==  null)
            controls = new Controls();
        controls.Enable();
    }

    private void OnDisable()
    {
        InputUser.onChange -= OnInputDeviceChanged;
        controls.Disable();
    }

    private void Start()
    {
        playerCharacterController = GetComponent<PlayerCharacterController>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void LateUpdate()
    {
        // TODO: Fire Input Held
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
            Debug.Log("Move input is: " + move);
            return move;
        }
        return Vector3.zero;
    }

    public Vector2 GetLookInput()
    {
        if (CanProcessInput)
        {
            Vector2 look = controls.Player.Look.ReadValue<Vector2>();
            if (InvertYAxis)
                look.y *= -1;
            if (InvertXAxis)
                look.x *= -1;
            look *= LookSensitivity;
            if (IsGamepad)
                look *= Time.deltaTime;
            Debug.Log("Look input is: " + look);
            return look;
        }
        return Vector2.zero;
    }
}
