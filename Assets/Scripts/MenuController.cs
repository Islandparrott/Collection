// Ailand Parriott
// 23.06.03
// functionality for main menu

using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuController : MonoBehaviour
{
    public PauseController pauseController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        //PauseController.isPaused = false;
    }

    public void QuitGame()
    {
        Application.Quit();

        Debug.Log("Application exited.");
    }
}

