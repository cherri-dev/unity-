using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Function to start the game
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene"); // Load your game scene
    }

    // Function to quit the application (for standalone builds)
    public void QuitGame()
    {
        Application.Quit();
    }
}
