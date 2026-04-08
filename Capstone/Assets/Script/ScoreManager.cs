using UnityEngine;
using TMPro; // This is for your UI text

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    private int score = 0;

    void Awake() { instance = this; }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "SCORE: " + score;
    }
}