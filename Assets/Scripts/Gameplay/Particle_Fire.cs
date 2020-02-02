using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle_Fire : MonoBehaviour
{
    public ParticleSystem particle;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = transform.parent.localScale;
        particle.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            startFire();
        }
        
    }

    public void startFire ()
    {
        particle.Play();
    }
}
