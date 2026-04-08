using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public GameObject laserPrefab;
    public Transform firePoint;

    private Rigidbody2D rb;
    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 1. Get Input
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        // 2. Shoot on Spacebar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void FixedUpdate()
    {
        // 3. Move the ship
        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime);

        // 4. Rotate the ship to face the direction of movement
        if (moveInput != Vector2.zero)
        {
            float angle = Mathf.Atan2(moveInput.y, moveInput.x) * Mathf.Rad2Deg - 90f;
            rb.rotation = angle;
        }
    }

    void Shoot()
    {
        // Spawns the laser at the nose with the ship's current tilt
        Instantiate(laserPrefab, firePoint.position, transform.rotation);
    }
}