using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathParticles : MonoBehaviour
{
    private ParticleSystem deathParticles;  //refers current particle system
    private bool didStart = false;          //let you know the particle system has started to play

    // Start is called before the first frame update
    void Start()
    {
        deathParticles = GetComponent<ParticleSystem>();
    }

    public void Activate()
    {
        didStart = true;
        deathParticles.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(didStart && deathParticles.isStopped)
        {
            Destroy(gameObject); //Play once
        }
    }

    public void SetDeathFloor(GameObject deathFloor)
    {
        if(deathParticles == null)
        {
            deathParticles = GetComponent<ParticleSystem>();
        }
        deathParticles.collision.SetPlane(0, deathFloor.transform);
    }
}
