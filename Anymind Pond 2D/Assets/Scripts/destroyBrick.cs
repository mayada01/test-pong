using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBrick : MonoBehaviour
{
    // Start is called before the first frame update
    private int numOfHit;
    public int numOfHitToDestroy;
    public ParticleSystem PopParticle;

    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            numOfHit++;
            if (numOfHit == numOfHitToDestroy)
            {
                DestroyBrick();
            }

        }

    }

    void DestroyBrick()
    {
        PopParticle.Play();
    }



}


