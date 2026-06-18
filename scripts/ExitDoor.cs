using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour
{
    public int requiredScore = 5;

    void Update()
    {
        if (ScoreManager.score >= requiredScore)
        {
            gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (ScoreManager.score >= requiredScore)
            {
                SceneManager.LoadScene("WinScene");
            }
        }
    }
}