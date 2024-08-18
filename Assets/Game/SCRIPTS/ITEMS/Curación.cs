using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curación : MonoBehaviour
{
    [SerializeField] GameObject player;
    private PlayerDamage playerLife;
    private bool check2;
    void Start()
    {
        playerLife = player.GetComponent<PlayerDamage>();
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player")  )
        {
            Debug.Log("Curando");
            playerLife.life += 20;
            Destroy(this.gameObject);
        }
    }
}
