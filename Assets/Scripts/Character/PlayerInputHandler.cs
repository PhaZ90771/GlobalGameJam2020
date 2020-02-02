using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(PlayerCharacterController))]
public class PlayerInputHandler : MonoBehaviour
{
    public enum CONTROL_MODE
    {
        KEYBOARDMOUSE,
        GAMEPAD
    }

    public CONTROL_MODE CurrentControlMode = CONTROL_MODE.KEYBOARDMOUSE;

    public float LookSensitivityMouse = 1f;
    public float LookSensitivityGamepad = 1f;
    
    public float TriggerAxisThreshold = 0.4f;

    public bool InvertYAxisMouse = false;
    public bool InvertXAxisMouse = false;

    public bool InvertYAxisGamepad = true;
    public bool InvertXAxisGamepad = false;

    public Controls Controls;

    private PlayerCharacterController playerCharacterController;

    public bool CanProcessInput { get => Cursor.lockState == CursorLockMode.Locked; }

    private void OnEnable()
    {
        if (Controls ==  null)
            Controls = new Controls();
        Controls.Enable();
        Controls.Player.Fire.performed += Fire_performed;
        Controls.Player.Jump.performed += Jump_performed;
        Controls.Player.Look.started += Look_started;

        Controls.Player.DebugReload.performed += ReloadLevel;
        Controls.Player.DebugAir.performed += ToggleElement;
        Controls.Player.DebugFire.performed += ToggleElement;
        Controls.Player.DebugEarth.performed += ToggleElement;
        Controls.Player.DebugWater.performed += ToggleElement;
    }

    private void ToggleElement(InputAction.CallbackContext obj)
    {
        switch (obj.action.name)
        {
            case "DebugAir":
            playerCharacterController.ToggleElement(PlayerCharacterController.ELEMENTS.AIR);
            break;
            case "DebugFire":
            playerCharacterController.ToggleElement(PlayerCharacterController.ELEMENTS.FIRE);
            break;
            case "DebugEarth":
            playerCharacterController.ToggleElement(PlayerCharacterController.ELEMENTS.EARTH);
            break;
            case "DebugWater":
            playerCharacterController.ToggleElement(PlayerCharacterController.ELEMENTS.WATER);
            break;
        }
    }

    private void Look_started(InputAction.CallbackContext obj)
    {
        CurrentControlMode = obj.control.device.name.Equals("Mouse") ? CONTROL_MODE.KEYBOARDMOUSE : CONTROL_MODE.GAMEPAD;
    }

    private void OnDisable()
    {
        Controls.Disable();
    }

    private void Jump_performed(InputAction.CallbackContext obj)
    {
        playerCharacterController.Jump();
    }

    private void Fire_performed(InputAction.CallbackContext obj)
    {
        playerCharacterController.Fire();
    }

    private void ReloadLevel(InputAction.CallbackContext obj)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Start()
    {
        playerCharacterController = GetComponent<PlayerCharacterController>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
    }

    public Vector3 GetMoveInput()
    {
        if (CanProcessInput)
        {
            Vector2 raw = Controls.Player.Move.ReadValue<Vector2>();
            Vector3 move = new Vector3(raw.x, 0f, raw.y);
            move = Vector3.ClampMagnitude(move, 1);
            return move;
        }
        return Vector3.zero;
    }

    public Vector2 GetLookInput()
    {
        if (CanProcessInput)
        {
            Vector2 look = Controls.Player.Look.ReadValue<Vector2>();
            if (CurrentControlMode == CONTROL_MODE.GAMEPAD)
            {
                if (InvertYAxisGamepad)
                    look.y *= -1;
                if (InvertXAxisGamepad)
                    look.x *= -1;
                look *= Time.deltaTime;
                look *= LookSensitivityGamepad;
            }
            else
            {
                if (InvertYAxisMouse)
                    look.y *= -1;
                if (InvertXAxisMouse)
                    look.x *= -1;
                look *= LookSensitivityMouse;
            }
            
            return look;
        }
        return Vector2.zero;
    }
}
