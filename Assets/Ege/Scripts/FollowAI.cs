using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowAI : MonoBehaviour
{
    NavMeshAgent agent;
    PlayerController pc;
    public GameObject ant;
    public Transform player;
    Vector3 dest;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        pc = ant.GetComponent<PlayerController>();
    }

    void Update()
    {
        if(pc.followme == true)
        {
            dest = player.position;
            agent.destination = dest;
        }
        
    }
}
