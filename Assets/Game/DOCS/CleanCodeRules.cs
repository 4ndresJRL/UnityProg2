using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///     int vidaMaxima; // Nomenclatura de camello
///     int vidamaxima; // Nomenclatura de serpiente o snake
///     int VidaMaxima; // Nomenclatura de Pascal
/// 
/// NOMBRES DE SCRIPTS
/// El nombre de el script lleva el nombre de lo que hace, no el objeto donde va
/// Por ejemplo si voy a programar un control de movimiento
/// el script se debe de llamar MovementController
/// 
/// Nomenclatura: Lleva la nomenclatura Pascal
/// 
/// 
/// NOMBRES DE VARIABLES
/// El nombre de la variable, lleva el nombre de el parametro exacto que se desea modificar
/// no el nombre de lo que se busca hacer
/// 
///     float intensity;
///     float fogIntensity;
///     float bloomIntensity;
///     
/// PRIVACIDAD DE VARIABLES
/// 
/// PRIVATE
/// Independientemente de la variable, si esta es privada, se debe de escribir la palabra private antes 
/// de declararla
/// 
///     private int stamina;
///     
/// INTERNAL
/// Es publica, dentro de el mismo espacio de trabajo o ensamblado. 
/// 
/// PROTECTED
/// Es un tipo de protección para las variables, que se usa en herencia. 
/// Las variables PROTECTED son publicas para la herencia, pero, privadas para otro script.
/// 
/// 
///[SERIALIZE FIELD]
///
/// Sirve para mostrar variables privadas, protected o internal en el inspector
/// 
/// MANAGER
/// Este sirve para gestion de informacion, ya sea, a nivel sistema o gameplay.
/// Por ejemplo un manager de items de el juego
/// Manager de misiones
/// 
/// HANDLER
/// Un Handler, puede tener inputs, pero, más que nada, sirve para
/// controlar una serie de eventos por detras de cámara
/// 
/// CONTROLLER
/// Un controller, como tal si "controla" acciones en base a inputs, y en todo momento tienes
/// conocimiento de esas acciones
/// </summary>
public class CleanCodeRules : MonoBehaviour
{
    /// <summary>
    /// SHORTCURS
    /// 
    /// Ctrl + D: Duplica la o las lineas seleccionadas
    /// 
    /// Ctrl + R,R: Renombra la variable, clase, metodo, funcion o lo que sea, en todas las
    /// instancias donde se esta usando
    /// 
    /// Ctrl + R,M: Todas las lineas seleccionadas crean un metodo, y este se manda a llamar en
    /// el lugar exacto de donde se extrajo el código
    /// 
    /// COMENTARIOS:
    /// Solamente se comenta lo que no se da a entender por su nombre
    /// 
    /// </summary>

    public float stamina;

    /// <summary>
    /// Sucede al darle play
    /// </summary>
    private void Awake()
    {
        Debug.Log("1");
    }


    /// <summary>
    /// Se ejecuta, cada vez que se activa el script
    /// </summary>
    private void OnEnable()
    {
        Debug.Log("2");
    }

    /// <summary>
    /// Se ejecuta la primera vez que se activa el script
    /// </summary>
    private void Start()
    {
        //Fire();
        Debug.Log("3");
    }


    /// <summary>
    /// Se ejecuta, cada vez que se desactiva el script
    /// </summary>
    private void OnDisable()
    {
        Debug.Log("4");
    }

    /// <summary>
    /// Se ejecuta unicamente en el editor, y cada vez que se realiza un cambio en el inspector
    /// </summary>
    private void OnValidate()
    {
        Debug.Log("Se cambio algo");
    }

    /// <summary>
    /// Se ejecuta cada frame
    /// </summary>
    private void Update()
    {

    }

    /// <summary>
    /// Se ejecuta cada frame, pero, fixeado a 60fps
    /// </summary>
    private void FixedUpdate()
    {

    }

    /// <summary>
    /// Este metodo controla los cambios de velocidad en el movimiento de el
    /// objeto
    /// </summary>
    private void Movement()
    {

    }

    /// <summary>
    /// Este metodo aplica los inputs del usuario
    /// a el movimiento para saber en que direccion debe de ir
    /// </summary>
    private void MovementHandler()
    {

    }

    /// <summary>
    /// Se manejan los inputs del usuario
    /// </summary>
    private void Controller()
    {
        
    }

    private void Talk()
    {

    }

    private void Run()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            stamina -= Time.deltaTime;
            // corres
        }
    }
}
