using UnityEngine;
using UnityEngine.UI; // IMPORTANT: This allows the script to talk to the Slider

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;

    public Slider healthSlider; // Drag your HealthBar Slider here!
    public GameObject gameOverUI;

    void Start()
    {
        currentHealth = maxHealth;

        // Initialize the slider values
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

        // Update the visual health bar
        if (healthSlider != null)
        {
            healthSlider.value = currentHealth;
        }

        if (currentHealth <= 0)
        {
            gameOverUI.SetActive(true);
            Time.timeScale = 0;
        }
    }
}