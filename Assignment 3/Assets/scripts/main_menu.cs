using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{
    // Function to start the game
    public void StartGame()
    {
        SceneManager.LoadScene("level 1"); // Load your game scene
    }

    // Function to quit the application (for standalone builds)
    public void QuitGame()
    {
        Application.Quit();
    }
}
