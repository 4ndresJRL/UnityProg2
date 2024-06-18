using UnityEngine;


/// <summary>
/// REQUIRE COMPONENT
/// Agrega a el gameobject que contenga el script el componente escrito en la linea
/// </summary>
[RequireComponent(typeof(Rigidbody))]
public class MovementController : MonoBehaviour
{
    public float walkSpeed;
    public float runSpeed;
    public float crouchSpeed;
    private GroundCheck checarPiso;
    public float jumpForce;

    private Rigidbody rb;
    public float FuerzaG;
    private void Metodo()
    { 
        //var rigidBody = GetComponent<Rigidbody>();

        //bool condicion = gameObject.active && gameObject.name == "Pedro";

        //if(condicion)
        //{
        //    // hago esto
        //}
        //else
        //{
        //    // hago esto otro
        //}

        //int numero = 5;

        //if(numero > 0 && numero < 1000)
        //{

        //}

        //switch (numero)
        //{
        //    case var num when numero > 0 && numero < 1000:
        //        break;

        //    case 1:
        //        break;

        //    case 2:
        //        break;

        //    case 3:
        //        break;
        //}

        //string cadena = (584.54456f * 783245.5465f + "Pepe" + true).ToString();

    }

    void Start()
    {
        checarPiso = GetComponent<GroundCheck>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Jump();
    }

    #region Movimiento

    private void Movement()
    {
        rb.velocity = MoveDirection() * ActualMoveSpeed();     
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

        return RunInputPressed()? runSpeed : CrouchInputPressed()? crouchSpeed : walkSpeed; 
    }

    //Este metodo nos regresa un vector, que apunta hacia donde nos vamos a mover, según las teclas que presionemos WASD
    private Vector3 MoveDirection()
    {
        return new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
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

    /// <summary>
    /// EJERCICIO 2
    /// 
    /// Una vez creado el script de GroundCheck, debe de usarse aqui mismo para determinar
    /// si el objeto que contenga este script puede saltar o no
    /// La condicion para que el objeto pueda saltar, es que este debe estar tocando el suelo
    /// </summary>
    private void Jump()
    {
        bool isGrounded = checarPiso.IsGround();
        if (JumpInputPressed() && isGrounded == true)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

        }
            rb.AddForce(Vector3.down * FuerzaG, ForceMode.Acceleration);
    }

    private bool JumpInputPressed()
    {
       return Input.GetKeyDown(KeyCode.Space);
    }

}
