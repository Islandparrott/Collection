// Ailand Parriott
// 23.05.25
// Adds controls and functionality to pong bars

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongController : MonoBehaviour
{
    public bool isPlayerOne;

    public float acceleration = 4f;
    public float friction = 1f;

    Rigidbody2D pongBar;

    Vector2 forceVector;
    Vector2 frictionVector;

    // Start is called before the first frame update
    void Start()
    {
        // assigns pongBar to given Pong RB
        pongBar = GetComponent<Rigidbody2D>();

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
        pongBar.AddForce(forceVector);
        forceVector = Vector2.zero;

        // pongBar velocity normalized returns vector of direction of velocity 
        // makes sure the friction is always in opposite direction
        frictionVector = -pongBar.velocity.normalized * friction;
        pongBar.AddForce(frictionVector);
        frictionVector = Vector2.zero;
    }
}
