using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    public int life;
    private bool check;

    private void Update()
    {
        if (check == true)
        {
            Destroy(this.gameObject);
        }
    }
    public void Daño(int cantidad)
    {
        life -= cantidad;
        if (life <= 0)
        {
            check = true;
        }
    }
}
