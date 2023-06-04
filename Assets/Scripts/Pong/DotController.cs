// Ailand Parriott
// 23.05.25
// functionality for dot
//
// REF
// | How to make Pong in Unity (Complete Tutorial) 🏓💥
//  | Had trouble with ball moving too fast. fixed by changing speed elsewhere.
//  | https://www.youtube.com/watch?v=AcpaYq0ihaM


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotController : MonoBehaviour
{
    public ScoreController scoreController;

    bool collided;

    float speed = 4f;
    float randX;
    float randY;

    public GameObject pongDotGO;

    Rigidbody2D pongDotRB;

    Vector2 startDirection;
    Vector2 moveVector;

    // Start is called before the first frame update
    void Start()
    {
        scoreController = GameObject.FindObjectOfType<ScoreController>();
        pongDotRB = GetComponent<Rigidbody2D>();

        spawnDot();
    }

    // Update is called once per frame
    void Update()
    {   
        
    }

    void FixedUpdate()
    {   
        //Vector2 dotVelocity = pongDotRB.velocity;
    }

    void spawnDot()
    {
        pongDotRB.velocity = Vector2.zero;

        pongDotGO.transform.position = new Vector3(0, 0, 0);

        // if value is < .5, -1. else 1.
        randX = Random.value < .5f ? -1f : 1f;
        randY = Random.value < .5f ? Random.Range(-1f, -.5f) : 
                Random.Range(.5f, 1f);

        startDirection = new Vector2(randX, randY).normalized * speed;


        //randX = Random.Range(-1f, 1f);
        //randY = Random.Range(-1f, 1f);
        //Debug.Log();

        //startDirection = new Vector2(randX, randY).normalized * speed;

        // keep having problems with dot moving extremely fast.
        pongDotRB.AddForce(startDirection, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("WallW"))
        {
            // had to use the declared scoreController to call it.
            scoreController.scoreRight++;
            scoreController.UpdateScore();

            spawnDot();
        } else if (collision.gameObject.CompareTag("WallE"))
        {
            scoreController.scoreLeft++;
            scoreController.UpdateScore();

            spawnDot();
        }
        
    }

}

// kept having problems with dot moving too fast. the dot speed was set to 
// public and was set very high.

