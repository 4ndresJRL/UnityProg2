using UnityEngine;
using UnityEngine.UIElements;

/// <summary>
/// REQUIRE COMPONENT
/// Agrega a el gameobject que contenga el script el componente escrito en la linea
/// </summary>
[RequireComponent(typeof(Rigidbody), typeof(GroundCheck))]
public class ControlDeMovimiento : MonoBehaviour
{

    [SerializeField, Header("Variables")]
    private float walkSpeed;
    public float runSpeed;
    public float crouchSpeed;

    public float jumpForce;

    private Rigidbody rb;
    private GroundCheck groundCheck;

    private Vector3 currentVelocity; // La velocidad actual de mi rigid body

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        groundCheck = GetComponent<GroundCheck>();
    }

    private void Update()
    {
        Jump();

        if (Input.GetKeyDown(KeyCode.K))
        {
            Death();
        }

    }

    private void FixedUpdate()
    {
        Movement();
    }

    #region Movimiento

    private void Movement()
    {
        currentVelocity = rb.velocity; // Me consigue la velocidad actual de el rigidbody
        //Indica hacia donde y a que velocidad de me voy a mover
        Vector3 movement = transform.localRotation * new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical") * ActualMoveSpeed());
        // Corrige mi velocidad en y
        movement.y = currentVelocity.y;
        //Aplica el movimiento
        rb.velocity = movement;
    }

    //Este metodo nos regresa un valor flotante que indica la velocidad a la que nos moveremos
    private float ActualMoveSpeed()
    {

        //if (RunInputPressed())
        //{
        //    return runSpeed;
        //}
        //else if (CrouchInputPressed())
        //{
        //    return crouchSpeed;
        //}
        //else
        //{
        //    return walkSpeed;
        //}

        return RunInputPressed() ? runSpeed : CrouchInputPressed() ? crouchSpeed : walkSpeed;
    }

    private bool RunInputPressed()
    {
        return Input.GetKeyDown(KeyCode.LeftShift);
    }

    private bool CrouchInputPressed()
    {
        return Input.GetKeyDown(KeyCode.LeftControl);
    }

    #endregion


    [ContextMenu("Morir")]
    public void Death()
    {
        transform.position += new Vector3(0, -10, 0);
        Debug.Log("Este objeto se murio de amor");
    }

    private void Jump()
    {
        // El ground check se puso como 1ra condición, para que esta
        // se ejecute primero, de manera que nos haga el debug de el rayo en el metodo IsGrounded
        if (groundCheck.IsGrounded() && JumpInputPressed())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private bool JumpInputPressed()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }
}
