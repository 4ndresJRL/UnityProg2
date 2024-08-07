using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WeaponSystem
{
    public class Handgun : Weapon // : MonoBehaivour
    {

        public override void Fire()
        {
            if (ammo >= 1)
            {
                Debug.Log($"Pistolita {weaponName} pium pium");
                ammo--;
                StopAllCoroutines();
            }
            else if (ammo <= 0 && totalAmmo >= 1)
            {
                Reload();
            }
            else if(totalAmmo <= 0)
            {
                Debug.Log("Shhtcktk");
                StopAllCoroutines();
            }
            
        }

        public override void Aim()
        {
            Debug.Log("Apuntando con pistola " + weaponName);
        }

        public override void Reload()
        {
            if (ammo < magazineSize)
            {
                if (totalAmmo >= 1)
                {
                    Debug.Log("Reloading...");
                    StartCoroutine(RecargarBalaPorBala());
                }
                else if (totalAmmo <= 0)
                {
                    Debug.Log("Cuando ****** pagan");
                }
            }
            else
            {
                Debug.Log("Arma llena");
            }
        }


        /// <summary>
        /// La corrutina yo le tengo que decir, cuando empieza
        /// y cuando termina
        /// </summary>
        IEnumerator RecargarBalaPorBala()
        {
            for (int i = 0; i < 6; i++) // i = 3
            {
                yield return new WaitForSeconds(3f);
                ammo++;
                totalAmmo--;
                Debug.Log("Bala recargada");
            }
            // se cierra la corrutina
        }

        int stamina;

        IEnumerator RecuperarStamina()
        {
            for (int i = stamina; stamina < 100; stamina++)
            {
                yield return new WaitForSeconds(0.5f);
                stamina++;
            }
        }


    }
}
