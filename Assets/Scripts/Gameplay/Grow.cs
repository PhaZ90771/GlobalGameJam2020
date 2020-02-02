using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour, ITriggerable
{
    private Rigidbody rb;
    private float growDir;
    Vector3 posGrown;
    Vector3 posShrunk;
    private float time;
    bool canGrow = true;


    public bool growFirst = true;
    public float speed = 1;
    public float triggableDistance = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        posGrown = transform.position;
        if(growFirst)
        {
            posGrown = transform.position + new Vector3(0, transform.localScale.y, 0);
            posShrunk = transform.position;
        }
        else
        {
            posGrown = transform.position;
            posShrunk = transform.position + new Vector3(0, -transform.localScale.y, 0);
        }
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
            time = 0f;
            StartCoroutine("StartGrow");
        }
        
    }
    IEnumerator StartGrow()
    {
        while (time < 1f)
        {
            if(growFirst)
            {
                rb.MovePosition(Vector3.Lerp(posShrunk, posGrown, time));

                time += speed * Time.deltaTime;
            }else
            {
                rb.MovePosition(Vector3.Lerp(posGrown, posShrunk, time));

                time += speed * Time.deltaTime;
            }

            yield return new WaitForFixedUpdate();
        }
        rb.position = growFirst ? posGrown : posShrunk;
        growFirst = !growFirst;
        yield return new WaitForSeconds(1);
        canGrow = true;


    }

    public void Trigger(float distance, List<PlayerCharacterController.ELEMENTS> playersElements)
    {
        if (distance < triggableDistance && playersElements.Contains(PlayerCharacterController.ELEMENTS.EARTH))
            growBlock();
    }

    public bool InRange(float distance, List<PlayerCharacterController.ELEMENTS> playersElements)
    {
        return distance < triggableDistance && playersElements.Contains(PlayerCharacterController.ELEMENTS.EARTH);
    }
}


