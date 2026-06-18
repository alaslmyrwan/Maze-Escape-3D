using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource coinSound;

    private bool collected = false;

    void OnTriggerEnter(Collider other)
    {
        if (!collected && other.CompareTag("Player"))
        {
            collected = true;

            ScoreManager.score++;

            if (coinSound != null)
            {
                coinSound.Play();
            }

            // نخفي شكل العملة
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;

            // نحذفها بعد ما يخلص الصوت
            Destroy(gameObject, 1f);
        }
    }
}