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

    public float acceleration = 4f;
    public float friction = 4f;

    Rigidbody2D pongBarRB;

    Vector2 forceVector;
    Vector2 frictionVector;

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

    // good for physics
    void FixedUpdate()
    {
        // gets movement input up and down
        if (isPlayerOne)
        {
            if (Input.GetKey(KeyCode.W))
            {
                forceVector = new Vector2(0f, 1 * acceleration);
                // applying force to bar
            } 
            if (Input.GetKey(KeyCode.S))
            {
                forceVector = new Vector2(0f, -1 * acceleration);
                // applying force to bar
            }
        } else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                forceVector = new Vector2(0f, 1 * acceleration);
            } 
            if (Input.GetKey(KeyCode.DownArrow))
            {
                forceVector = new Vector2(0f, -1 * acceleration);
            }
        }
        pongBarRB.AddForce(forceVector);
        forceVector = Vector2.zero;

        // pongBarRB velocity normalized returns vector of direction of velocity 
        // makes sure the friction is always in opposite direction
        frictionVector = -pongBarRB.velocity.normalized * friction;
        pongBarRB.AddForce(frictionVector);
        frictionVector = Vector2.zero;
    }
}
