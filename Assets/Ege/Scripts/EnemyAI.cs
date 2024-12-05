using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    NavMeshAgent agent;
    PlayerController pc;
    public GameObject ant;
    public Transform[]  waypoints;
    int waypointindex;
    Vector3 target;

    public float radius;
    [Range(0,360)]
    public float angle;
    public GameObject player;
    public LayerMask targetMask;
    public LayerMask obsMask;
    public bool canSeePlayer;

    private Animator animator; /* Düþman animasyonu için */



    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
        player = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(FOVRoutine());

        pc = ant.GetComponent<PlayerController>();
    }

    void Update()
    {
        if(Vector3.Distance(transform.position, target) < 1)
        {
            IterateWaypointIndex();
            UpdateDestination();
        }

        if(canSeePlayer)
        {
            Debug.Log("YAKALANDIN!");
        }

        /*if(pc.followme == true)
        {
            agent.speed *= 3;
        }*/
    }


    private IEnumerator FOVRoutine()
    {
        WaitForSeconds wait = new WaitForSeconds(0.2f);

        while(true)
        {
            yield return wait;
            FieldOfViewCheck();
        }
    }

    private void FieldOfViewCheck()
    {
        Collider[] rangeChecks = Physics.OverlapSphere(transform.position, radius, targetMask);

        if(rangeChecks.Length != 0)
        {
            Transform target = rangeChecks[0].transform;
            Vector3 dir = (target.position - transform.position).normalized;

            if(Vector3.Angle(transform.forward, dir) < angle/2)
            {
                float dis = Vector3.Distance(transform.position, target.position);

                if(!Physics.Raycast(transform.position, dir, dis, obsMask))
                {
                    canSeePlayer = true;
                }
                else
                {
                    canSeePlayer = false;
                }
            }
            else
            {
                canSeePlayer = false;
            }
        }
        else if(canSeePlayer)
        {
            canSeePlayer = false;
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
