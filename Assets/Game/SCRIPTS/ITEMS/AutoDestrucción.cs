using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Este script destruye el spawner y hace que se dehjen de instancear enemigos
public class AutoDestrucción : MonoBehaviour
{
    [SerializeField] private GameObject Spawner;
    [SerializeField] private float radio;
    [SerializeField] private LayerMask playerMask;
    private void Update()
    {
        if (Physics.CheckSphere(transform.position, radio, playerMask))
        {
            if (Input.GetKeyDown(KeyCode.E)) 
            {
                Destroy(Spawner);
            }
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radio);
    }
}
