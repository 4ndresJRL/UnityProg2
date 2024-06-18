using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    private float musX;
    private float musY;

    [SerializeField] private float musSenceX;
    [SerializeField]private float musSenceY;

    private Transform pers;

    private float camRot = 0;

    private void Start()
    {
        pers = transform.parent;
        Cursor.lockState = CursorLockMode.Locked;  
    }

    private void Update()
    {
        musX = Input.GetAxis("Mouse X") * musSenceX * Time.deltaTime;
        musY = Input.GetAxis("Mouse Y") * musSenceY * Time.deltaTime;

        camRot -= musY;

        camRot = Mathf.Clamp(camRot, -90, 90);

        transform.localRotation = Quaternion.Euler(camRot, 0, 0);

        pers.Rotate(Vector3.up * musX);
    }
}
