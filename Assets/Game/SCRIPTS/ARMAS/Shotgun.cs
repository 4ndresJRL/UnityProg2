
using UnityEngine;


namespace WeaponSystem
{
    public class Shotgun : Weapon
    {
        public float spread;

        public override void Fire()
        {
            Debug.Log($"Escopeta {weaponName} pam pam");
        }

        public override void Aim()
        {
            Debug.Log("Apuntando");
        }

        public override void Reload()
        {
            Debug.Log("Recargando...");
        }
    }
}
