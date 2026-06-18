using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public void RestartGame()
    {
        ScoreManager.score = 0;
        SceneManager.LoadScene("GameScene");
    }

    public void MainMenu()
    {
        ScoreManager.score = 0;
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Application.Quit();

        Debug.Log("Game Closed");
    }
}