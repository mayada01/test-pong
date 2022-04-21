using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingBall : MonoBehaviour
{

    private float ballSpeed = 2f;
    private Rigidbody2D rbBall;
    private bool startGame = false;
    private bool GameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        rbBall = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space") && !startGame)//Or StartButton
        {
            StartGame();

        }
    }

    public void StartGame()
    {
        startGame = true;
        float x = Random.Range(1f, 2f);
        float y = Random.Range(1f, 2f);
        rbBall.velocity = new Vector2(ballSpeed * x, ballSpeed * y);
    }

    public void RestartGame()
    {
        GameOver = false;
        startGame = false;
    }


    void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.tag == "Finish")
        {

            GameOver = true;
        }
    }

}

    
