using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingBall : MonoBehaviour
{

    private float ballSpeed = 2f;
    private Rigidbody2D rbBall;
    public static bool startGame = false;
    public static bool GameOver = false;
    public static int numOfLivesLeft;
    private int numOfLives = 3;
    private Vector2 startBallPosition;

    // Start is called before the first frame update
    void Start()
    {
        rbBall = GetComponent<Rigidbody2D>();
        startBallPosition = new Vector2 (this.transform.position.x, this.transform.position.y);
        numOfLivesLeft = numOfLives;
    }

    void Update()
    {
        if (startGame) //Initiate Game Once Start button is clicked
        {
            
            
            StartGame();  

        }
    }

    public void StartGame()
    {
        
        rbBall.velocity = new Vector2(ballSpeed * 1.5f, ballSpeed * 1.5f);
        startGame = false;

    }

    public void RestartGame() // Restart Game After GameOver.
    {
        GameOver = false;
        startGame = true;
        this.gameObject.SetActive(true);
        ResetBallPosition();
        numOfLivesLeft = numOfLives;
    }

    public void startGameActive()
    {
        startGame = true;

    }


    void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.tag == "Finish")
        {

            numOfLivesLeft--;
            if(numOfLivesLeft == 0 )
            {
                GameOver = true;
            }
            else if (numOfLivesLeft > 0)
            {
                ResetBallPosition();
                startGame = true;
            }
        }
    }

    void ResetBallPosition()
    {
        this.transform.position = new Vector2 (startBallPosition.x, startBallPosition.y);
    }

}

    
