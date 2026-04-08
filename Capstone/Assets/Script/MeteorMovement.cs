using UnityEngine;

public class MeteorMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    public float fallSpeed = 2f;
    public float rotationSpeed = 50f;
    public Vector2 fallDirection = Vector2.down; // Falling "down" by default

    void Start()
    {
        // Gives each meteor a random rotation speed between 20 and 100
        rotationSpeed = Random.Range(20f, 100f);

        // Randomly decide if it spins left or right
        if (Random.value > 0.5f) rotationSpeed *= -1;
    }

    void Update()
    {
        // 1. Move the meteor slowly in the fall direction
        transform.Translate(fallDirection * fallSpeed * Time.deltaTime, Space.World);

        // 2. Rotate the meteor over time
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}