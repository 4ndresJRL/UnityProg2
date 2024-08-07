using System;
using System.Drawing;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{

    public Transform rayOrigin; // De donde va a salir el raycast
    public float range;
    public LayerMask groundLayers;

    private float numero;

    private void Update()
    {
        if (IsGrounded())
        {
            Debug.Log("Tocando el suelo");
        }
    }

    public bool IsGrounded()
    {
        #region Raycast
        //if (Physics.Raycast(rayOrigin.position, -rayOrigin.up, range,groundLayers))
        //{
        //    // va hacer esto
        //}
        //else
        //{
        //    // hace esto
        //}
        #endregion
        Debug.DrawRay(rayOrigin.position, -rayOrigin.up * range, UnityEngine.Color.red);
        return Physics.Raycast(rayOrigin.position, -rayOrigin.up, range, groundLayers);
    }

    private void OnDrawGizmos()
    {
        //Gizmos.color = UnityEngine.Color.red;
        //Gizmos.DrawRay(rayOrigin.position, -rayOrigin.up * range);
    }

}
