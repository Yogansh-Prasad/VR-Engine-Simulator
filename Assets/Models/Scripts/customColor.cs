using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customColor : MonoBehaviour
{
    [SerializeField] private Material[] materials;


    private void Start()
    {
        ApplyFirstMaterial();
    }
    public void ApplyFirstMaterial()
    {
        ApplyMaterial(0);
    }

    public void ApplySecondMaterial()
    {
        ApplyMaterial(1);
    }

    public void ApplyThirdMaterial()
    {
        ApplyMaterial(2);
    }

    private void ApplyMaterial(int materialIndex)
    {
        // get all the child objects of this game object
        Transform[] children = transform.GetComponentsInChildren<Transform>();

        // loop through each child object
        foreach (Transform child in children)
        {
            // if the child has a renderer component, change its material
            Renderer renderer = child.GetComponent<Renderer>();
            if (renderer != null)
            {
                // apply the material to the child's renderer component
                renderer.material = materials[materialIndex];
            }
        }
    }
}


