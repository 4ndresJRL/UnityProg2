using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento3D : MonoBehaviour
{
    private CharacterController control;
    private float movX;
    private float movZ;
    private Vector3 movimiento;

    [SerializeField] private float velocidad;
    [SerializeField] private float velSalto;

    private Vector3 velY;
    [SerializeField] private float gravedad = -9.8f;

    private bool isGrounded;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float radius;
    [SerializeField] private LayerMask groundMask;



    private void Start()
    {
        control = GetComponent<CharacterController>();

    }

    private void Update()
    {
        Ground();
        Movimiento();
        Salto();

    }

    private void Movimiento()
    {
        movX = Input.GetAxis("Horizontal");
        movZ = Input.GetAxis("Vertical");

        movimiento = transform.right * movX + transform.forward * movZ;
        control.Move(movimiento * velocidad * Time.deltaTime);
    }

    private void Ground()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, radius, groundMask);
    }

    private void Salto()
    {
        if (isGrounded && velY.y < 0)
        {
            velY.y = 0;
        }

        if (Input.GetButton("Jump") && isGrounded)
        {
            velY.y = Mathf.Sqrt(velSalto * -2 * gravedad);
        }

        velY.y += gravedad * Time.deltaTime;
        control.Move(velY * Time.deltaTime);
    }
}
