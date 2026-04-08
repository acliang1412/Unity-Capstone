using UnityEngine;

public class Meteor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // If the laser touches the meteor
        if (other.CompareTag("Laser"))
        {
            ScoreManager.instance.AddScore(5); // Reward for shooting!
            Destroy(other.gameObject); // Destroy the laser
            Destroy(gameObject); // Destroy the meteor
        }
    }
}