using UnityEngine;
 // Ensure you have the correct namespace for your scriptable object

public class Spawner : MonoBehaviour
{
    public float spawnInterval = 2f; // Time interval between spawns
    public float minX = -2.2f;
    public float maxX = 2.2f; // X-axis range for spawning
    public GameObject[] objects; // Array to hold the objects to spawn  

    public void FixedUpdate()
    {
        // Call the SpawnObjects method at regular intervals
        if (Time.time % spawnInterval < Time.deltaTime)
        {
            SpawnObjects();
        }
    }
    public void SpawnObjects()
    {
        // Generate a random position within the specified range
        float randomX = Random.Range(minX, maxX);
        Vector3 spawnPosition = new Vector3(randomX, transform.position.y, transform.position.z);

        // Choose a random object from the array to spawn
        GameObject randomObject = objects[Random.Range(0, objects.Length)];

        // Instantiate the object at the spawn position with no rotation
        Instantiate(randomObject, spawnPosition, Quaternion.identity);
    }
}
