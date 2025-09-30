using UnityEngine;

public class Coin : MonoBehaviour
{
    public int scoreValue = 5; // points per coin

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Coin collected!");
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.AddScore(scoreValue);
            }

            Destroy(gameObject); // removes coin from scene
        }
    }
}
