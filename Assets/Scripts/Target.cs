using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Target : MonoBehaviour
{
    private GameObject endGoal;
    public Transform[] points;
    private NavMeshAgent _agent;
    // Start is called before the first frame update

    private void Awake()
    {
         _agent = GetComponent<NavMeshAgent>();
        endGoal = GameObject.Find("End Point");
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        _agent.destination = endGoal.transform.position;
    }
}
