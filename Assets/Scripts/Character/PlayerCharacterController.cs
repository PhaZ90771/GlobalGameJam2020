using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerInputHandler)), RequireComponent(typeof(CharacterController))]
public class PlayerCharacterController : MonoBehaviour
{
    public float LookRotationSpeed = 1f;
    public float MoveMaxGroundSpeed = 10f;
    public float MoveAccelerationGround = 15f;

    public Vector3 CharacterVelocity { get; private set; }

    private Camera camera;
    private PlayerInputHandler playerInputHandler;
    private CharacterController characterController;

    private bool IsGrounded { get => GroundCheck(); }

    private void Awake()
    {
        camera = GetComponentInChildren<Camera>();
        playerInputHandler = GetComponent<PlayerInputHandler>();
        characterController = GetComponent<CharacterController>();

        characterController.enableOverlapRecovery = true;
    }

    private void Update()
    {
        HandlePlayerMovement();
    }

    private void HandlePlayerMovement()
    {
        var move = playerInputHandler.GetMoveInput();
        var look = playerInputHandler.GetLookInput();

        // Horizontal Rotation
        {
            var rotX = new Vector3(0f, look.x * LookRotationSpeed, 0f);
            transform.Rotate(rotX, Space.Self);
        }
        // Vertical Rotation
        {
            var lookY = look.y * LookRotationSpeed;
            camera.transform.Rotate(lookY, 0f, 0f, Space.Self);

            var euler = camera.transform.eulerAngles;
            euler.y = Mathf.Clamp(euler.y, -89f, 89f);
            camera.transform.eulerAngles = euler;
        }
        // Movement
        {
            var orientedMove = transform.TransformVector(move);
            var targetVelocity = orientedMove * MoveMaxGroundSpeed;

            if (IsGrounded)
            {
                CharacterVelocity = Vector3.Lerp(CharacterVelocity, targetVelocity, MoveAccelerationGround * Time.deltaTime);
            }
        }
        characterController.Move(CharacterVelocity * Time.deltaTime);
    }

    private bool GroundCheck()
    {
        return true;
    }
}
