using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public float survivalTime = 60f; // 1 minute to win
    public TextMeshProUGUI timerText;
    private bool gameEnded = false;

    void Update()
    {
        if (gameEnded) return;

        if (survivalTime > 0)
        {
            survivalTime -= Time.deltaTime;
            timerText.text = "Fuel: " + Mathf.RoundToInt(survivalTime).ToString();
        }
        else
        {
            WinGame();
        }
    }

    void WinGame()
    {
        gameEnded = true;
        // Save score for the End Screen
        PlayerPrefs.SetInt("FinalScore", ScoreManager.score);
        SceneManager.LoadScene("Ending");
    }
}