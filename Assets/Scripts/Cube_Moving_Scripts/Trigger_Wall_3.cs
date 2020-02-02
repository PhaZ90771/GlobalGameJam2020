using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Wall_3 : MonoBehaviour, ITriggerable

{

    public Cube_Behavior cube_Behavior;

    Cube_Behavior.Direction dir = Cube_Behavior.Direction.negativeX;

    bool test;
    // Start is called before the first frame update
    private void Start()
    {
        test = cube_Behavior.test;
    }
    // Update is called once per frame
    void Update()
    {
    }
    // moves cube based on direction given
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("canMoveCube"))
        {
            cube_Behavior.MoveCube(dir);
        }
    }
    void testMovment()
    {
        cube_Behavior.MoveCube(dir);

    }

    public void Trigger()
    {
        testMovment();
    }
}
