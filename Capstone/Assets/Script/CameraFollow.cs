using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Drag your Car here
    public float smoothSpeed = 0.125f;
    public Vector3 offset = new Vector3(0, 0, -10); // Keeps the camera "back" from the car

    void FixedUpdate()
    {
        // Calculate where the camera wants to be
        Vector3 desiredPosition = target.position + offset;

        // Smoothly slide from current position to desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;
    }
}