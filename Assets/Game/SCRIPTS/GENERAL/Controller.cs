using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private CharacterController ctrl;
    private float movX;
    private float movZ;
    private Vector3 movi;

    [SerializeField] private float vel;
    [SerializeField] private float velJump;

    private Vector3 velY;
    [SerializeField] private float gravedad = -9.8f;

    private bool isGrounded;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float radius;
    [SerializeField] private LayerMask groundMask;



    private void Start()
    {
        ctrl = GetComponent<CharacterController>();
    }

    private void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, radius, groundMask);

        movX = Input.GetAxis("Horizontal");
        movZ = Input.GetAxis("Vertical");

        movi = transform.right * movX + transform.forward * movZ;
        ctrl.Move(movi * vel * Time.deltaTime);

        if (isGrounded && velY.y < 0)
        {
            velY.y = 0;
        }

        if (Input.GetButton("Jump") && isGrounded)
        {
            velY.y = Mathf.Sqrt(velJump * -2 * gravedad);
        }

        velY.y += gravedad * Time.deltaTime;
        ctrl.Move(velY * Time.deltaTime);
    }
}
