using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;

    void Update()
    {
        // Capture WASD or Arrow Key input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // This forces the velocity to match your input exactly. 
        // If movement is 0, velocity becomes 0 instantly.
        rb.velocity = new Vector2(movement.x * moveSpeed, movement.y * moveSpeed);
    }
}