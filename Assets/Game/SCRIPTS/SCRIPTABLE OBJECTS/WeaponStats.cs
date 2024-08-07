using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Weapon Stats", menuName = "Create New Weapon Stats")] // Create/AssetMenu
public class WeaponStats : ScriptableObject
{
    public string weaponName;
    public int damage;
    public int ammo;
    public int maxAmmo;
    public int totalAmmo;
    public int magazineSize;
    public float range;
    public float fireRate;
}

