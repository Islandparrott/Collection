// Ailand Parriott
// 23.05.27
// adding functionality for the scoress

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    //updated in DotController
    public int scoreLeft = 0;
    public int scoreRight = 0;

    public TextMeshProUGUI TMPLeft;
    public TextMeshProUGUI TMPRight;

    // Start is called before the first frame update
    void Start()
    {
        TMPLeft.text = scoreLeft.ToString();
        TMPRight.text = scoreRight.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        TMPLeft.text = scoreLeft.ToString();
        TMPRight.text = scoreRight.ToString();
    }

    void ResetScore()
    {
        scoreLeft = 0;
        scoreRight = 0;
    }

}
