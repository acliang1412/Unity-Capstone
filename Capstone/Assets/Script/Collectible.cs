using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int points = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.instance.AddScore(points);
            Destroy(gameObject); // Disappear when picked up
        }
    }
}