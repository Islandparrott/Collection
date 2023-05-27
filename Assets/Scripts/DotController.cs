// Ailand Parriott
// 23.05.25
// functionality for dot

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotController : MonoBehaviour
{
    public ScoreController scoreController;

    bool collided;

    public float speed = 4f;
    float randX;
    float randY;

    Rigidbody2D pongDotRB;

    Vector2 startDirection;
    Vector2 moveVector;

    // Start is called before the first frame update
    void Start()
    {
        pongDotRB = GetComponent<Rigidbody2D>();

        randX = Random.Range(-1f, 1f);
        randY = Random.Range(-.5f, .5f);

        startDirection = new Vector2(randX, randY).normalized * speed;

        pongDotRB.AddForce(startDirection);
    }

    // Update is called once per frame
    void Update()
    {   
        
    }

    void FixedUpdate()
    {   
        Vector2 dotVelocity = pongDotRB.velocity;

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("WallW"))
        {
            // had to use the declared scoreController to call it.
            scoreController.scoreLeft++;
        } else if (collision.gameObject.CompareTag("WallE"))
        {
            scoreController.scoreRight++;
        }
    }


}
