﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle_Fire : MonoBehaviour, ITriggerable
{
    public ParticleSystem particle;
    public float triggerDistance = 10f;
    // Start is called before the first frame update
    void Start()
    {
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

    public void Trigger(float distance)
    {
        if(distance < triggerDistance)
        {
            startFire();
            Destroy(this.gameObject, 3f);
        }
    }

    public bool InRange(float distance)
    {
        return distance < triggerDistance;
    }
}