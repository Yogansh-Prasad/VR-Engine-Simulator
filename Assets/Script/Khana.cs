using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Khana : MonoBehaviour
{
    [SerializeField] GameObject og;
    [SerializeField] GameObject cooked;
    private float timer;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Khana"))
        {
            timer += Time.deltaTime;

            if (timer > 5f)
            {
                Instantiate(cooked, og.transform.position, og.transform.rotation);
                og.SetActive(false);
                timer = 0f;
            }
        }
    }
}

