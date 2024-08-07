using UnityEditor;
using UnityEngine;

namespace WeaponSystem
{

    /// <summary>
    /// Una clase abstracta no tiene definici�n, es decir, no contiene
    /// pasos l�gicos, ya que no se sabe a que se refiere.
    /// 
    /// Entonces la definicion de la clase abstracta, se da en la herencia
    /// 
    /// Los metodos abstractos, no tienen definicion ni contienen l�gica,
    /// por que funcionan diferente seg�n la herencia
    /// </summary>
    public abstract class Weapon : MonoBehaviour
    {
        [SerializeField] protected WeaponStats stats;

        [SerializeField] protected string weaponName;
        [SerializeField] protected int damage;
        [SerializeField] protected int ammo;
        [SerializeField] protected int maxAmmo;
        [SerializeField] protected int totalAmmo;
        [SerializeField] protected int magazineSize;
        [SerializeField] protected float range;
        [SerializeField] protected float fireRate;


        private void Start()
        {
            weaponName = stats.weaponName;
            damage = stats.damage;
            ammo = stats.ammo;
            maxAmmo = stats.maxAmmo;
            totalAmmo = stats.totalAmmo;
            magazineSize = stats.magazineSize;
            range = stats.range;
            fireRate = stats.fireRate;

        }

        public abstract void Fire();
        public abstract void Aim();
        public abstract void Reload();

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawRay(transform.position, transform.rotation * transform.forward * range);
        }

    }

}