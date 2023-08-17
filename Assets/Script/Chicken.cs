using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chicken : MonoBehaviour
{
    [SerializeField] private Transform[] movePositionTransforms;

    private NavMeshAgent navMeshAgent;
    private float timer = 2f;
    private int currentDestinationIndex = 0;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            currentDestinationIndex = (Random.Range(0,3)) % movePositionTransforms.Length;
            navMeshAgent.destination = movePositionTransforms[currentDestinationIndex].position;
            timer = 2f;
        }
    }

}
