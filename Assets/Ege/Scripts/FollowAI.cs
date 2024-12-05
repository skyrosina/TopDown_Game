using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Windows;

public class FollowAI : MonoBehaviour
{
    NavMeshAgent agent;
    PlayerController pc;
    public GameObject ant;
    public Transform player;
    Vector3 dest;

    
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        pc = ant.GetComponent<PlayerController>();
    }

    void Update()
    {
        if(pc.followMe == true)
        {
            if(pc.input.magnitude < 0.1f)
            {
                animator.SetBool("isRunning", false);
                return;
            }
            if (pc.input.magnitude > 0.1f)
            {
                animator.SetBool("isRunning", true);
            }
            dest = player.position;
            agent.destination = dest;
        }
        
    }
}
