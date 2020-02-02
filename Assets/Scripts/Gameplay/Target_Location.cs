using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Location : MonoBehaviour
{
    public bool trigger = false;

    public Material noKeyMat;
    public Material keyDeliveredMat;

    private Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material = noKeyMat;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Key"))
        {
            rend.material = keyDeliveredMat;
            Debug.Log("Key Delivered");
            trigger = true;
        }
    }
}
