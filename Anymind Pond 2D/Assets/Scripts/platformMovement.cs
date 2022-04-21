using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMovement : MonoBehaviour
{

    private float movementOfPlatform;
    private float platformSpeed = 8f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movementOfPlatform = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movementOfPlatform * platformSpeed, rb.velocity.y);
    }

}
