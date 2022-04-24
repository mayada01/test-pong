using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenManager : MonoBehaviour
{

    public GameObject StartScreen;
    public GameObject GameOverScreen;
    public GameObject WinScreen;
    public GameObject[] brickObjects;
    private int numOfDestroyedBricks;
    public GameObject ballObj;

    // Update is called once per frame
    void Update()
    {
        if (movingBall.startGame)
        {
            StartScreen.SetActive(false);
            GameOverScreen.SetActive(false);

        }
        if (movingBall.GameOver)
        {
            GameOverScreen.SetActive(true);
        }
        RestoreBricks();
        CheckIfWin();


    }
    void RestoreBricks()
    {
        if (movingBall.GameOver)
        {
            for (int i = 0; i < brickObjects.Length; i++)
            {
                brickObjects[i].SetActive(true);
            }
        }
    }
    
    void CheckIfWin()
    {
        if (destroyBrick.numOfDestroyedBricks == brickObjects.Length)
        {
            WinScreen.SetActive(true);
            ballObj.SetActive(false);
        }
    }
}
