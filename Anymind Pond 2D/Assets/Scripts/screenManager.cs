using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenManager : MonoBehaviour
{

    public GameObject StartScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (movingBall.startGame)
        {
            StartScreen.SetActive(false);
        }
        
    }
}
