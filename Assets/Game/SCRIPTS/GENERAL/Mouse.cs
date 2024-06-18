using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    private float VelX;
    private float VelY;

    [SerializeField] private float mouseSenceX;
    [SerializeField]private float mouseSenceY;

    private Transform pers;

    private float camRotacion = 0;

    private void Start()
    {
        pers = transform.parent;
        Cursor.lockState = CursorLockMode.Locked;  
    }

    private void Update()
    {
        VelX = Input.GetAxis("Mouse X") * mouseSenceX * Time.deltaTime;
        VelY = Input.GetAxis("Mouse Y") * mouseSenceY * Time.deltaTime;

        camRotacion -= VelY;

        camRotacion = Mathf.Clamp(camRotacion, -90, 90);

        transform.localRotation = Quaternion.Euler(camRotacion, 0, 0);

        pers.Rotate(Vector3.up * VelX);
    }
}
