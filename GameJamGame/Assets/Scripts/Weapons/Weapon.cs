using UnityEngine;

[CreateAssetMenu(menuName = "Weapons/Weapon")]
public class Weapon : ScriptableObject
{
    [Header("Weapon Stats")]
    public string weaponName = "New Weapon";
    public float fireRate = 0.2f; // Time between shots
    public float bulletSpeed = 15f;
    public int bulletsPerShot = 1; // for shotguns or burst fire
    public float spreadAngle = 0f; // degrees between bullets
    
    [Header("Magazine Settings")]
    public int magazineSize = 10; // bullets per magazine
    public float reloadTime = 1.5f; // time to reload

    [Header("References")]
    public GameObject bulletPrefab;
}
