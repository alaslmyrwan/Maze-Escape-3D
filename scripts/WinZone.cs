using UnityEngine;
using UnityEngine.SceneManagement;

public class WinZone : MonoBehaviour
{
    public int requiredScore = 6;
    public AudioSource winSound;

    private bool hasWon = false;

    void OnTriggerEnter(Collider other)
    {
        if (!hasWon && other.CompareTag("Player") && ScoreManager.score >= requiredScore)
        {
            hasWon = true;

            if (winSound != null)
            {
                winSound.Play();
            }

            Invoke("LoadWinScene", 2.5f);
        }
    }

    void LoadWinScene()
    {
        SceneManager.LoadScene("WinScene");
    }
}