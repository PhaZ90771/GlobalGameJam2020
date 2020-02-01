using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Behavior : MonoBehaviour
{
    [Header("Use WSDA keys when testing cube movement")]

    public float speed;
    public float moveDistance;
    public bool test;

    private Vector3 pos;
    public bool isMoving = false;
    private Rigidbody rb;


    public enum Direction { positiveX, negativeX, positiveZ, negativeZ };
    Direction direction;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        pos = transform.position;
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
                case Direction.negativeX:
                    {
                        rb.AddForce(new Vector3(1.033f, 0, 0), ForceMode.VelocityChange);
                        break;
                    }
                case Direction.positiveX:
                    {
                        rb.AddForce(new Vector3(-1.033f, 0, 0), ForceMode.VelocityChange);
                        break;
                    };
                case Direction.positiveZ:
                    {
                        rb.AddForce(new Vector3(0, 0, 1.033f), ForceMode.VelocityChange);

                        break;
                    }; ;
                case Direction.negativeZ:
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