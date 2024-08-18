using UnityEngine;
using UnityEngine.Rendering;

namespace WeaponSystem
{

    public class WeaponHandler : MonoBehaviour
    {
        [SerializeField] private Weapon currentWeapon; // Arma que est? equipada actualmente
        [SerializeField] private Weapon[] weapons = new Weapon[2]; // Inventario de armas

        private void Start()
        {
            currentWeapon = weapons[0];
        }

        // Update is called once per frame
        private void Update()
        {

            FireWeapon();

            AimWeapon();

            ReloadWeapon();
        }

        /// <summary>
        /// EJERCICIO Y TAREA
        /// 
        /// En el metodo de disparar, deben de hacer que dispare, unicamente si tiene munici?n
        /// Si no tiene munici?n, pero, tiene munici?n en las reservas, debe recargar
        /// Si no tiene munici?n, y tampoco tiene munici?n en las reservas, debe hacer un debug que diga "Shhtcktk"
        /// 
        /// En apuntar, ese lo dejan igual
        /// 
        /// En recargar, debe de poder recargar si tiene menos municion que la capacidad maxima de el cargador, y si tiene municion en las reservas
        /// Si tiene menos municion que la capacidad maxima de el cargador, y no tiene municion en las reservas, debe de hacer un debug que diga "Cuando ****** pagan"
        /// </summary>
        private void FireWeapon()
        {
            if (FireInput())
            {
                currentWeapon.Fire();
            }
        }

        private void AimWeapon()
        {
            if (AimInput())
            {
                currentWeapon.Aim();
            }
        }

        private void ReloadWeapon()
        {
            if (ReloadInput())
            {
                currentWeapon.Reload();
            }
        }



        private bool FireInput()
        {
            return Input.GetMouseButtonDown(0);
        }

        private bool AimInput()
        {
            return Input.GetMouseButton(1);
        }

        private bool ReloadInput()
        {
            return Input.GetKeyDown(KeyCode.R);
        }

    }
}

