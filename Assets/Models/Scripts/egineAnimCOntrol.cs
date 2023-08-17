using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class egineAnimCOntrol : MonoBehaviour
{

    public void disableEngine()
    {
        // Find all objects with the specified tag
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("Engine_Part");

        // Print the names of the objects found
        foreach (GameObject obj in objectsWithTag)
        {
            //Debug.Log("Object found: " + obj.name);
            obj.SetActive(false);
        }
    }
}
