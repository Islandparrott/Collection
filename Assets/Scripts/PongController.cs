// Ailand Parriott
// 23.05.25
// 23.05.25
// Adds controls and functionality to pong bars

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongController : MonoBehaviour
{
    public bool isPlayerOne;

    Rigidbody2D pongBarRB;

    public float friction = .9f;

    public int speed = 24;
    int input;
    Vector2 direction;
    Vector2 pongBarVelocity;

    // Start is called before the first frame update
    void Start()
    {
        // assigns pongBarRB to given Pong RB
        pongBarRB = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void movement(int inp)
    {
        direction = new Vector2(0f, inp);
        direction.Normalize();
        pongBarVelocity = direction * speed;
        pongBarRB.velocity = pongBarVelocity;
    }

    // good for physics
    void FixedUpdate()
    {
        // gets direction input up and down
        if (isPlayerOne)
        {
            if (Input.GetKey(KeyCode.W))
            {
                movement(1);
            } 
            if (Input.GetKey(KeyCode.S))
            {
                movement(-1);
            }
        } else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                movement(1);
            } 
            if (Input.GetKey(KeyCode.DownArrow))
            {
                movement(-1);
            }
        }

        // works for some reason? doesnt apply friction but stops the bars from 
        // moving
        pongBarRB.velocity *= friction;

    }
}
