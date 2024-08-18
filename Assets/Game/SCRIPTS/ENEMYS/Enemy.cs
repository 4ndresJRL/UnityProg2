using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;
//Este Script hace que los enemigos generados de la nada te sigan o vuelvan
//a su posici�n original, evitando el error de que los enemigos no tienen
//puntos de patrullaje al ser instanciado
public class Enemigo : MonoBehaviour
{
    private Transform player;
    public NavMeshAgent agent;

    [SerializeField] private float radio;
    [SerializeField] private LayerMask playerMask;
    //Posici�n original
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
        {//El NavMesh Agent se dirige al jugador si lo detecta en su rango
            agent.SetDestination(player.position);
        }
        else
        {
            //No lo encontro as� que se regresa a su posici�n original
            agent.SetDestination(positionOr);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radio);
    }


}
