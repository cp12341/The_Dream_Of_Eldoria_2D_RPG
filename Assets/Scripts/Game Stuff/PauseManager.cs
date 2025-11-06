using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    private bool isPaused;
    public GameObject pausePanel;
    public GameObject inventoryPanel;
    public GameObject gameOverPanel;
    public GameObject gameWinPanel;
    public bool usingPausePanel;
    public string mainMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
        pausePanel.SetActive(false);  // Ensure the panel is hidden at the start
        inventoryPanel.SetActive(false);
        gameOverPanel.SetActive(false);  // Hide Game Over at start
        gameWinPanel.SetActive(false);   // Hide Game Win at start
        usingPausePanel = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("pause"))
        {
            ChangePause();
        }
    }

    public void ChangePause()
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0f;
            usingPausePanel = true;
        }
        else 
        {
            inventoryPanel.SetActive(false);
            pausePanel.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    public void QuitToMain()
    {
        SceneManager.LoadScene(mainMenu);
        Time.timeScale = 1f;
    }

    public void SwitchPanels()
    {
        usingPausePanel = !usingPausePanel;
        if (usingPausePanel)
        {
            pausePanel.SetActive(true);
            inventoryPanel.SetActive(false);
        }
        else 
        {
            inventoryPanel.SetActive(true);
            pausePanel.SetActive(false);
        }
    }

    public void TriggerGameOver()
    {
        gameOverPanel.SetActive(true);  // Show Game Over screen
        Time.timeScale = 0f;  // Pause the game
    }

    // Trigger the Game Win screen (similar to Game Over)
    public void TriggerGameWin()
    {
        gameWinPanel.SetActive(true);  // Show Game Win screen
        Time.timeScale = 0f;  // Pause the game
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;  // Ensure time is reset to normal
        pausePanel.SetActive(false);  // Hide the pause panel
        isPaused = false;  // Reset pause state
        SceneManager.LoadScene("Level1");  // Load level1 or use SceneManager.GetActiveScene().name
    }

    public void RestartGameDungeon()
    {
        Time.timeScale = 1f;  // Ensure time is reset to normal
        pausePanel.SetActive(false);  // Hide the pause panel
        isPaused = false;  // Reset pause state
        SceneManager.LoadScene("Dungeon");  // Load level1 or use SceneManager.GetActiveScene().name
    }
}
