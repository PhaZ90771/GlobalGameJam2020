using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grow : MonoBehaviour
{
    private Rigidbody rb;
    private float growDir;
    Vector3 posOne;
    Vector3 posTwo;
    Vector3 nextPos;
    Vector3 startPos;
    private float time;
    bool canGrow = true;


    public bool growFirst = true;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        posOne = transform.position;
        posTwo = transform.position + new Vector3(0, transform.localScale.y, 0);

        Debug.Log(posOne.y + "  " +  posTwo.y);
        growDir = 1;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            growBlock();
        }
    }

     public void growBlock ()
    {
        if(canGrow)
        {
            canGrow = false;

            if (growFirst)
            {
                nextPos = posTwo;
            }
            else
            {
                nextPos = posOne;
            }
            time = 0f;
            StartCoroutine("StartGrow");
           
        }
        
    }
    IEnumerator StartGrow()
    {
        Debug.Log("Test");
        while (time < 1f)
        {
            rb.MovePosition(Vector3.Lerp())
            time += speed * Time.deltaTime;
            yield return null;
        }
        rb.position = nextPos;
        canGrow = true;
        yield return null;

    }


}

