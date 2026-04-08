using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Follow Settings")]
    public Transform player;           // Drag your Player ship here
    public float verticalOffset = 10f; // Distance above the player to spawn

    [Header("Spawn Settings")]
    public GameObject meteorPrefab;    // Drag your Meteor Prefab here
    public float spawnRate = 1.5f;     // Seconds between spawns
    public float xRange = 10f;         // Width of the spawn zone

    private float nextSpawnTime;

    void Update()
    {
        // 1. DYNAMIC FOLLOW LOGIC
        if (player != null)
        {
            // This forces the Spawner to stay 10 units above the player's current position
            transform.position = new Vector3(player.position.x, player.position.y + verticalOffset, 0);
        }

        // 2. SPAWN TIMER
        if (Time.time >= nextSpawnTime && Time.timeScale > 0)
        {
            SpawnMeteor();
            // Adds a tiny bit of random timing so it feels natural
            float randomDelay = Random.Range(-0.3f, 0.3f);
            nextSpawnTime = Time.time + spawnRate + randomDelay;
        }
    }

    void SpawnMeteor()
    {
        // 3. RANDOM POSITIONING
        // Spawns relative to the Spawner's current position (which is following the player)
        float randomX = Random.Range(-xRange, xRange);
        Vector3 spawnPos = new Vector3(transform.position.x + randomX, transform.position.y, 0f);

        Instantiate(meteorPrefab, spawnPos, Quaternion.identity);
    }

    // This draws the red line in Scene View so you can see your "Danger Zone"
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Vector3 start = new Vector3(transform.position.x - xRange, transform.position.y, 0);
        Vector3 end = new Vector3(transform.position.x + xRange, transform.position.y, 0);
        Gizmos.DrawLine(start, end);
    }
}