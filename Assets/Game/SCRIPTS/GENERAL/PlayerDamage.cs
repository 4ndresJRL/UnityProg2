using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
    public int life;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Enemigo"))
        {
            life -= 5;
            if (life == 0) 
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
           
        }
    }
}
