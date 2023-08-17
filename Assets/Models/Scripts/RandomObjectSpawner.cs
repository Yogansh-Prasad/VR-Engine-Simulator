using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{
    public GameObject[] objectsToSpawn; // array of objects to spawn
    public Transform[] spawnLocations; // array of spawn locations

    private List<GameObject> spawnedObjects = new List<GameObject>(); // list to store the spawned objects

    public void SpawnRandomObjects()
    {
        // Destroy the previously spawned objects
        foreach (GameObject spawnedObject in spawnedObjects)
        {
            Destroy(spawnedObject);
        }
        spawnedObjects.Clear();

        for (int i = 0; i < spawnLocations.Length; i++)
        {
            // Choose a random object from the array
            GameObject randomObject = objectsToSpawn[Random.Range(0, objectsToSpawn.Length)];
            // Spawn the random object at the corresponding spawn location
            GameObject spawnedObject = Instantiate(randomObject, spawnLocations[i].position, spawnLocations[i].rotation);
            // Add the spawned object to the list
            spawnedObjects.Add(spawnedObject);
            // Optionally, you can perform additional customization on the spawned object here
        }
    }
}
