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
    private float rotateY;

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
            rotateY += (look.y * LookRotationSpeed);
            rotateY = Mathf.Clamp(rotateY, -90f, 90f);
            camera.transform.localRotation = Quaternion.Euler(-rotateY, 0f, 0f);
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
