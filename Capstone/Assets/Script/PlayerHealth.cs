using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // <-- ADD THIS

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;

    public Slider healthSlider;
    public GameObject gameOverUI;

    void Start()
    {
        currentHealth = maxHealth;
        if (healthSlider != null)
        {
            healthSlider.maxValue = maxHealth;
            healthSlider.value = maxHealth;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            TakeDamage(1);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (healthSlider != null)
        {
            healthSlider.value = currentHealth;
        }

        if (currentHealth <= 0)
        {
            // 1. Save the score so the Ending scene can display it
            PlayerPrefs.SetInt("FinalScore", ScoreManager.score);

            // 2. Load the Ending scene
            SceneManager.LoadScene("Ending");

        }
    }
}