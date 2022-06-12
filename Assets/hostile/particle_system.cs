using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle_system : MonoBehaviour
{

    public ParticleSystem explosion;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            explosion.Play();
        }
    }
}
