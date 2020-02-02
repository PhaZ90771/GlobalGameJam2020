using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Cube_Behavior : MonoBehaviour
{
    public float Speed;
    public float MoveDistance;

    private bool isMoving = false;
    private Rigidbody rb;

    public enum Direction { PositiveX, NegativeX, PositiveZ, NegativeZ };
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (rb.velocity.sqrMagnitude <= 0.01f)
        {
            isMoving = false;
        }
        else
        {
            isMoving = true;
        }
    }

    public void MoveCube(Direction i)
    {
        if (!isMoving)
        {
            switch (i)
            {
                case Direction.NegativeX:
                    {
                        rb.AddForce(new Vector3(1.033f, 0, 0), ForceMode.VelocityChange);
                        break;
                    }
                case Direction.PositiveX:
                    {
                        rb.AddForce(new Vector3(-1.033f, 0, 0), ForceMode.VelocityChange);
                        break;
                    };
                case Direction.PositiveZ:
                    {
                        rb.AddForce(new Vector3(0, 0, 1.033f), ForceMode.VelocityChange);

                        break;
                    }; ;
                case Direction.NegativeZ:
                    {
                        rb.AddForce(new Vector3(0, 0, -1.033f), ForceMode.VelocityChange);
                        break;
                    }; ;
                default:
                    {
                        Debug.Log("Direction for cube not assigned");
                        return;
                    };
            }
        }
    }
}