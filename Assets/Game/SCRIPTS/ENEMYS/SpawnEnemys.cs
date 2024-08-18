using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemys : MonoBehaviour
{
    [SerializeField] GameObject Enemigos;
    [SerializeField] private float tiempo;
    //genera puntos de spawn
    [SerializeField] private Transform[] spawn;
    //genera el valor random
    private int spawnX;
    [SerializeField] private int radio;
    [SerializeField] LayerMask playerMask;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(SpawnearEnemigos());
        }
    }
    IEnumerator SpawnearEnemigos()
    {
        while (true) 
        {
            yield return new WaitForSeconds(tiempo);
            Instantiate(Enemigos, spawn[spawnX]);
            spawnX = Random.Range(0, spawn.Length);
        }
    }

}
