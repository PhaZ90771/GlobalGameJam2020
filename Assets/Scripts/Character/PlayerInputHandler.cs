using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

[RequireComponent(typeof(PlayerCharacterController))]
public class PlayerInputHandler : MonoBehaviour
{
    public enum CONTROL_MODE
    {
        KEYBOARDMOUSE,
        GAMEPAD
    }

    public CONTROL_MODE CurrentControlMode = CONTROL_MODE.GAMEPAD;

    public float LookSensitivityMouse = 1f;
    public float LookSensitivityGamepad = 1f;
    
    public float TriggerAxisThreshold = 0.4f;

    public bool InvertYAxisMouse = false;
    public bool InvertXAxisMouse = false;

    public bool InvertYAxisGamepad = true;
    public bool InvertXAxisGamepad = false;

    private PlayerCharacterController playerCharacterController;
    private Controls controls;

    public bool CanProcessInput { get => Cursor.lockState == CursorLockMode.Locked; }

    private void OnEnable()
    {
        if (controls ==  null)
            controls = new Controls();
        controls.Enable();
        controls.Player.Fire.performed += Fire_performed;
        controls.Player.Jump.performed += Jump_performed;
        controls.Player.Look.started += Look_started;
    }

    private void Look_started(InputAction.CallbackContext obj)
    {
        CurrentControlMode = obj.control.device.name.Equals("Mouse") ? CONTROL_MODE.KEYBOARDMOUSE : CONTROL_MODE.GAMEPAD;
    }

    private void OnDisable()
    {
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

    private void Update()
    {
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
        if (CanProcessInput)
        {
            Vector2 look = controls.Player.Look.ReadValue<Vector2>();
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
