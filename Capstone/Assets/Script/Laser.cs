using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed = 20f;

    void Start()
    {
        // This is the fix! The laser will disappear after 2 seconds 
        // regardless of how far you fly into the galaxy.
        Destroy(gameObject, 2f);
    }

    void Update()
    {
        // Move in the direction the laser is pointing (Up relative to itself)
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}