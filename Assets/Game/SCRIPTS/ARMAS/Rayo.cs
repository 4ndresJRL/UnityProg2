using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float rayRangue;
    [SerializeField] private LayerMask zombieMask;

    private RaycastHit hit;
    private Ray ray;

    private Spawner spawner;

    private void Start()
    {
        spawner = FindAnyObjectByType<Spawner>();
    }

    private void Update()
    {
    }
}
