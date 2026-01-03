using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum Status
{
    Idle,
    Walking,
    Busy
}

public class EmployeeMovement : MonoBehaviour
{
    [SerializeField] public Transform target;
    [SerializeField] public Transform position;
    [SerializeField] public Status status;

    NavMeshAgent agent;
    
    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        target.position = transform.position;
    }

    
    public void Update()
    {
        agent.SetDestination(target.position);
    }

}
