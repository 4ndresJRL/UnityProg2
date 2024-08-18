using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class Enemigo : MonoBehaviour
{
    private Transform player;
    public NavMeshAgent agent;

    [SerializeField] private float radio;
    [SerializeField] private LayerMask playerMask;

    [SerializeField] private Vector3 positionOr;
    private void Start()
    {
        positionOr = transform.position;    
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();

    }

    private void Update()
    {
        if (Physics.CheckSphere(transform.position, radio, playerMask))
        {
            agent.SetDestination(player.position);
        }
        else
        {

            agent.SetDestination(positionOr);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radio);
    }


}
