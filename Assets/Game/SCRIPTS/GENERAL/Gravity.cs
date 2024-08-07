using UnityEngine;


/// <summary>
/// Gravity, en caso de no estar tocando el suelo, nos va a empujar hacia abajo
/// </summary>
public class Gravity : MonoBehaviour
{
    public float fallSpeed;
    public float acceleration = 0;
    public float baseAcceleration = 2;

    private Rigidbody rb;
    private GroundCheck groundCheck;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        groundCheck = GetComponent<GroundCheck>();
    }

    private void FixedUpdate()
    {
        if (!groundCheck.IsGrounded()) // Cuando no este tocando el suelo
        {
            acceleration += Time.deltaTime; // Mi aceleracion de caida aumenta
            rb.AddForce(Vector3.down * fallSpeed * acceleration, ForceMode.Acceleration); // Caigo con fuerza de aceleracion
        }
        else
        {
            acceleration = baseAcceleration;
        }
    }

}