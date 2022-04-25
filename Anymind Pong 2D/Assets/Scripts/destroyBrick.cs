using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBrick : MonoBehaviour
{
    // Start is called before the first frame update
    private int numOfHit;
    public int numOfHitToDestroy;
    public ParticleSystem PopParticle;
    public GameObject brick;
    public static int numOfDestroyedBricks;

    void Update()
    {
        if (movingBall.GameOver)
        {
            
            numOfHit = 0;
            numOfDestroyedBricks = 0;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            numOfHit++;
            if (numOfHit == numOfHitToDestroy)
            {
                DestroyBrick();
                numOfDestroyedBricks++;
            }

        }
        

    }

    void DestroyBrick()
    {
        PopParticle.Play();
        brick.SetActive(false);
    }



}


