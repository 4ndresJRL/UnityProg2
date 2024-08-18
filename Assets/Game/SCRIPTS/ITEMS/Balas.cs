using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balas : MonoBehaviour
{
    [SerializeField] GameObject arma;
    private Arma bullets;
    private void Start()
    {
        bullets = arma.GetComponent<Arma>();
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Más balas");
            bullets.balas += 10;
            Destroy(this.gameObject);
        }
    }
}
