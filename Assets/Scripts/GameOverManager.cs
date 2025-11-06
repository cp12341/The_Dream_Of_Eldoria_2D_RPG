using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverPanel;

    public void GameOver()
    {
        gameOverPanel.SetActive(true);  // Show Game Over screen
        Time.timeScale = 0;  // Pause the game
    }

    public void RestartGame()
    {
        Time.timeScale = 1;  
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  // Reload current scene
    }

    public void QuitToMainMenu()
    {
        Time.timeScale = 1;  
        SceneManager.LoadScene("MainMenu");  // Load Main Menu scene
    }
}
