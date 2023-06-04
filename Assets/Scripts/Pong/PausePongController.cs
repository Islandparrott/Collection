// Ailand Parriott
// 23.06.03
// Adds functionality to the pause menus in Pong

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePongController : MonoBehaviour
{
    public GameObject PongPause;
    public static bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        PongPause.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PauseHandler();
        }
    }

    public void PauseHandler()
    {
        isPaused = !isPaused;
        PongPause.SetActive(isPaused);
        if (isPaused)
        {
            Time.timeScale = 0f;
        } else
        {
            Time.timeScale = 1f;
        }
    }

}
