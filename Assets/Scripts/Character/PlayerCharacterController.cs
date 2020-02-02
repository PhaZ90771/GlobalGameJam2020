using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(PlayerInputHandler)), RequireComponent(typeof(CharacterController))]
public class PlayerCharacterController : MonoBehaviour
{
    public float LookRotationSpeed = 1f;
    public float MoveMaxGroundSpeed = 10f;
    public float MoveAccelerationGround = 15f;
    public float JumpForce = 10f;
    public float GravityDownForce = 20f;
    public float GroundCheckDistance = 0.1f;

    public Vector3 CharacterVelocity { get; private set; }

    private Camera camera;
    private PlayerInputHandler playerInputHandler;
    private CharacterController characterController;

    private float rotateY;
    private bool attemptJump = false;

    private bool IsGrounded { get; set; }

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

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.CompareTag("Door"))
        {
            Door door = hit.collider.gameObject.GetComponent<Door>();
            door.Open();
        }
    }

    private void HandlePlayerMovement()
    {
        var move = playerInputHandler.GetMoveInput();
        var look = playerInputHandler.GetLookInput();

        GroundCheck();

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

                GroundCheck();
                if (IsGrounded && attemptJump)
                {
                    CharacterVelocity = new Vector3(CharacterVelocity.x, 0f, CharacterVelocity.z);
                    CharacterVelocity += Vector3.up * JumpForce;
                }
                attemptJump = false;
            }
            else
            {
                CharacterVelocity += Vector3.down * GravityDownForce * Time.deltaTime;
            }
        }

        characterController.Move(CharacterVelocity * Time.deltaTime);
    }

    internal void Fire()
    {
        Ray ray = new Ray(camera.transform.position, camera.transform.forward);

        if (Physics.Raycast (ray, out RaycastHit hit))
        {
            var triggerables = hit.collider.gameObject.GetComponents<MonoBehaviour>();
            foreach (var t in triggerables)
            {
                var trigger = t as ITriggerable;
                if (trigger != null)
                    trigger.Trigger(hit.distance);
            }

            Debug.DrawLine(camera.transform.position, hit.point, Color.red);
            return;
        }

        Debug.DrawRay(camera.transform.position, camera.transform.forward, Color.green);
    }

    internal void Jump()
    {
        attemptJump = true;
    }

    private void GroundCheck()
    {
        IsGrounded = false;

        var start = transform.position + Vector3.down * characterController.height / 2f;
        Ray ray = new Ray(start, Vector3.down);
        
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            IsGrounded = hit.distance < GroundCheckDistance;

            Debug.DrawRay(start, Vector3.down, Color.red);
            return;
        }

        Debug.DrawRay(start, Vector3.down, Color.green);
    }
}
