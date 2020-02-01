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
    private bool isMoving = false;
 


    public enum Direction{positiveX, negativeX, positiveZ, negativeZ};
    Direction direction;
    // Start is called before the first frame update
    void Start()
    {
        speed = speed / 10;
        pos = transform.position;
    }

    public void MoveCube(Direction i)
    {
        Vector3 endPos;
        switch (i)
        {
            case Direction.negativeX:
                {
                    endPos = pos - new Vector3(moveDistance, 0, 0);
                    break;
                }
            case Direction.positiveX:
                {
                    endPos = pos + new Vector3(moveDistance, 0, 0);
                    break;
                };
            case Direction.positiveZ:
                {
                    endPos = pos + new Vector3(0, 0, moveDistance);
                    break;
                }; ;
            case Direction.negativeZ:
                {
                    endPos = pos - new Vector3(0, 0, moveDistance);
                    break;
                }; ;
            default:
                {
                    Debug.Log("Direction for cube not assigned");
                    return;
                };
        }
        if(!isMoving)
        {
            StartCoroutine(Move(endPos));
            isMoving = true;
        }
    }

    IEnumerator Move(Vector3 endPos)
    {
        float time = 0;
        while (endPos != transform.position)
        {
            transform.position = Vector3.Lerp(pos, endPos, time);
            time += speed * Time.deltaTime;
            Debug.Log(time);
            yield return null;
        }
        pos = transform.position;
        isMoving = false;
        yield return null;
    }
}
