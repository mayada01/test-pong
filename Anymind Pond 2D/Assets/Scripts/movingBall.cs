using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingBall : MonoBehaviour
{

    private float ballSpeed = 2f;
    private Rigidbody2D rbBall;
    public static bool startGame = false;
    public static bool youWin = false;
    public static bool GameOver = false;
    

    // Start is called before the first frame update
    void Start()
    {
        rbBall = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (startGame) //Initiate Game Once Start button is clicked
        {
            StartGame();
            startGame = false;

        }
    }

    public void StartGame()
    {
        
        rbBall.velocity = new Vector2(ballSpeed * 1.75f, ballSpeed * 1.75f);
        
    }

    public void RestartGame()
    {
        GameOver = false;
        startGame = false;
    }

    public void startGameActive()
    {
        startGame = true;
    }


    void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.tag == "Finish")
        {

            GameOver = true;
        }
    }

}

    
