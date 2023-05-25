// Ailand Parriott
// 23.05.25
// 23.05.25
// functionality for dot

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotController : MonoBehaviour
{
    bool collided;

    public float speed = 4f;
    float randX;
    float randY;

    Rigidbody2D pongDotRB;

    Vector2 moveDirection;
    Vector2 moveVector;

    // Start is called before the first frame update
    void Start()
    {
        randX = Random.Range(-1f, 1f);
        randY = Random.Range(-1f, 1f);
        moveDirection = new Vector2(randX, randY).normalized * speed;

        pongDotRB = GetComponent<Rigidbody2D>();
        pongDotRB.AddForce(moveDirection);
    }

    // Update is called once per frame
    void Update()
    {   
        
    }

    void FixedUpdate()
    {   
        
    }

    // called whenever collides with another object
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected!");
        if(collision.gameObject.CompareTag("WallNS") && !collided)
        {
            // tried using velocity to update location, just use force.
            Vector2 reflectVector = Vector2.Reflect(moveDirection, 
                    collision.contacts[0].normal);
            pongDotRB.AddForce(reflectVector, ForceMode2D.Impulse);

            collided = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {   
        collided = false;
    }
}
