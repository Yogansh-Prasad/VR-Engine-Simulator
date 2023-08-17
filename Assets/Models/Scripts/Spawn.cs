using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] spawnObjects; 
    public Transform spawnTransform; 
    
    int[] arr;

    private void Start()
    {
        arr = new int[spawnObjects.Length];
    }
    public void SpawnObject(int index)
    {
        if (arr[index] == 0)
        {
            Instantiate(spawnObjects[index], spawnTransform.position, spawnTransform.rotation);
            arr[index] = 1;
        }
    }


}
