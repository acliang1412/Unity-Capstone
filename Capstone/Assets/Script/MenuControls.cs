using UnityEngine;
using TMPro; // This is required to talk to TextMeshPro objects

public class MenuControls : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Drag your 'Final Score' text object here in the Inspector!

    void Start()
    {
        // 1. Pull the score from the "Safe" (PlayerPrefs)
        int finalScore = PlayerPrefs.GetInt("FinalScore", 0);

        // 2. Update the text on screen
        if (scoreText != null)
        {
            scoreText.text = "Final Score: " + finalScore.ToString();
        }
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("The game has closed.");
    }
}
