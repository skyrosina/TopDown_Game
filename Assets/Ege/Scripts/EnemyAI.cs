using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform[]  waypoints;
    int waypointindex;
    Vector3 target;
    public GameObject player;
    public float Deg = 45f;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
    }

    void Update()
    {
        if(Vector3.Distance(transform.position, target) < 1)
        {
            IterateWaypointIndex();
            UpdateDestination();
        }

        Vector3 dir = player.transform.position - transform.position;
        if(Mathf.Abs(Vector3.Angle(transform.forward, dir)) < Deg)
        {
            Debug.Log("YAKALANDIN!");
        }
    }

    void UpdateDestination()
    {
        target = waypoints[waypointindex].position;
        agent.SetDestination(target);
    }

    void IterateWaypointIndex()
    {
        waypointindex++;
        if(waypointindex == waypoints.Length)
        {
            waypointindex = 0;
        }
    }
}
