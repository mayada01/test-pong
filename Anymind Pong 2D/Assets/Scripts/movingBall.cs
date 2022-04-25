using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingBall : MonoBehaviour
{

    private float ballSpeed = 2.5f;
    private Rigidbody2D rbBall;
    public static bool startGame = false;
    public static bool GameOver = false;
    private bool gameIsPlaying = false;
    public static int numOfLivesLeft;
    private int numOfLives = 3;
    private Vector2 startBallPosition;
    public static bool ResetPositionAfterBallFall;

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
    private void MoveBall()
    {
        float x = Random.Range(-1f, 1.5f);
        float y = Random.Range(1.3f, 1.5f);
        rbBall.velocity = new Vector2(ballSpeed * x, ballSpeed * y);
    }


    public void StartGame()
    {

        MoveBall();
        gameIsPlaying = true;
        startGame = false;
        //destroyBrick.numOfDestroyedBricks = 0;

    }

    public void RestartGame() // Restart Game After GameOver.
    {
        GameOver = false;
        startGame = true;
        gameIsPlaying = true;
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


        if (other.gameObject.tag == "Finish" )
        {

            numOfLivesLeft--;
            if(numOfLivesLeft == 0 )
            {
                GameOver = true;
                gameIsPlaying = false;
            }
            else if (numOfLivesLeft > 0)
            {
                ResetPositionAfterBallFall = true;
                startGame = false;
                gameIsPlaying = false;

            }
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "platform")
        {
           if (gameIsPlaying)
           {
                MoveBall(); // Reset ball movement direction with each platform hit to avoid eternal vertical movement
           }
            
        }
    }

    void ResetBallPosition()
    {
        this.transform.position = new Vector2 (startBallPosition.x, startBallPosition.y);
    }

    public void ExitApplication()
    {
        Application.Quit();
    }

    public void Continue()
    {
        ResetBallPosition();
        startGame = true;
        ResetPositionAfterBallFall = false;
    }

}

    
