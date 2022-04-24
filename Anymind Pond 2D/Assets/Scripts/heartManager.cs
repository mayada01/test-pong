using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heartManager : MonoBehaviour
{
    public GameObject[] hearts;
  
    // Update is called once per frame
    void Update()
    {
        HeartSystem();
    }

    void HeartSystem()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < movingBall.numOfLivesLeft)
            {
                hearts[i].SetActive(true);
            }
            else
            {
                hearts[i].SetActive(false);
            }
        }
    }
}
