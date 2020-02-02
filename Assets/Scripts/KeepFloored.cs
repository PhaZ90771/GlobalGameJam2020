using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepFloored : MonoBehaviour
{
    public float GroundCheckDistance = 0.1f;

    private bool isGrounded;

    private Collider collider;
    private Rigidbody rb;

    private void Awake()
    {
        collider = GetComponent<Collider>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        GroundCheck();
    }

    private void GroundCheck()
    {
        isGrounded = false;

        var start = transform.position + Vector3.down * collider.bounds.size.y / 2f;
        Ray ray = new Ray(start, Vector3.down);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            isGrounded = hit.distance < GroundCheckDistance;

            if (isGrounded)
            {
                rb.MovePosition(new Vector3(0f, -hit.distance, 0f));
            }

            Debug.DrawRay(start, Vector3.down, Color.red);
            return;
        }

        Debug.DrawRay(start, Vector3.down, Color.green);
    }
}
