using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using UnityEngine.Events;
using System;

public class SoketController : MonoBehaviour
{
    XRSocketInteractor interactor;
    GameObject parent;
   
    private void OnEnable()
    {
        interactor = GetComponent<XRSocketInteractor>();
        interactor.selectEntered.AddListener(ParentFunc);
    }

    private void OnDisable()
    {
        //interactor.selectEntered.RemoveListener(ParentFunc);
    }

    private void Start()
    {
    }

    private void ParentFunc(SelectEnterEventArgs arg0)
    {
        Debug.Log("Goyat noob");
        parent = GameObject.Find("GameObject");
        //SetParentWithoutScale(arg0.interactableObject.transform, parent.transform);
        //arg0.interactableObject.transform.SetParent(parent.transform);
    }

    void SetParentWithoutScale(Transform child, Transform newParent)
    {
        // Store the original local scale of the child object
        Vector3 originalScale = child.localScale;

        // Set the parent of the child object
        child.SetParent(newParent, false);

        // Restore the original local scale of the child object
        child.localScale = originalScale;
    }
}
