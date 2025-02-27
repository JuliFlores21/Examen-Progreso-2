using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AINavigator : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform target;
    // Start is called before the first frame update
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
    }
}
