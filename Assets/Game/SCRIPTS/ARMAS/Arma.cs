using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public int balas;
    private Transform cam;
    private RaycastHit hit;
    [SerializeField] private float distancia;
    [SerializeField] private int daño;

    private ParticleSystem sitemaParticula;

    [SerializeField] private Transform partM;
    private void Start()
    {
        cam = transform.parent;
        sitemaParticula = transform.GetChild(0).GetComponent<ParticleSystem>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && balas >= 1)
        {
            balas--;
            sitemaParticula.Play();
            //El raycast se dispara desde la camara y devuelve unos valores si golpea algo dentro de la variable distancia
            if (Physics.Raycast(cam.position, cam.forward, out hit, distancia))
            {
                Debug.Log(hit.transform.name);

                if (hit.transform.tag == "Enemigo")
                {
                    hit.transform.GetComponent<EnemyLife>().Daño(daño);
                    Instantiate(partM, hit.point, partM.rotation);
                }
            }
        }
    }
}

