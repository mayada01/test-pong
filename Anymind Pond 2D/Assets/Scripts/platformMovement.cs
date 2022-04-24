using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMovement : MonoBehaviour
{

    private float movementOfPlatform;
    private float platformSpeed = 15f;
    private Rigidbody2D rb;

    private bool rightButtonPress;
    private bool leftButtonPress;
    private Vector2 intialPlatformPos;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        intialPlatformPos = new Vector2(this.transform.position.x, this.transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        
        movementOfPlatform += platformSpeed * Time.deltaTime;
        movementOfPlatform = Mathf.Clamp(movementOfPlatform, 0f, 6f);

        if (Input.GetKey(KeyCode.RightArrow) || rightButtonPress)
        {
            rb.velocity = new Vector2(movementOfPlatform, rb.velocity.y);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || leftButtonPress)
        {
            rb.velocity = new Vector2(movementOfPlatform*-1, rb.velocity.y);
        }
        else 
        {
            rb.velocity = new Vector2(0,0);
        }


        if (movingBall.startGame)
        {
            ResetPlatformPosition();
        }


    }
    void ResetPlatformPosition()
    {
        this.transform.position = new Vector2(intialPlatformPos.x, intialPlatformPos.y);
    }

    public void RightButtonTrue()
    {
        rightButtonPress = true;
    }
    public void RightButtonFalse()
    {
        rightButtonPress = false;
    }
    public void LeftButtonTrue()
    {
        leftButtonPress = true;
    }
    public void LeftButtonFalse()
    {
        leftButtonPress = false;
    }

}
