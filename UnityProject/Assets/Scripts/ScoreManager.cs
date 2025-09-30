using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [Header("Score Settings")]
    public int myScore = 0;
    public int winScore = 50;

    [Header("UI References")]
    public TMP_Text scoreText;
    public TMP_Text winText;

    void Start()
    {
        UpdateScoreUI();
        winText.gameObject.SetActive(false); // hide win message initially
    }

    public void AddScore(int amount)
    {
        myScore += amount;
        UpdateScoreUI();

        if (myScore >= winScore)
        {
            Win();
        }
    }

    void UpdateScoreUI()
    {
        scoreText.text = myScore + "/" + winScore;
    }

    void Win()
    {
        winText.gameObject.SetActive(true);
    }
}
