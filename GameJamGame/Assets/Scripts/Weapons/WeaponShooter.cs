using System.Collections;
using UnityEngine;

public class WeaponShooter : MonoBehaviour
{
    public Weapon currentWeapon;
    private float lastFireTime;
    private int currentAmmo;
    private bool isReloading = false;

    private void Start()
    {
        if (currentWeapon != null)
        {
            currentAmmo = currentWeapon.magazineSize; // Initialize ammo count
        }
    }
    private void Update()
    {
        if (currentWeapon == null) return;

        if (Input.GetKeyDown(KeyCode.R) && !isReloading && currentAmmo < currentWeapon.magazineSize)
        {
            StartCoroutine(Reload());
            return;
        }
        if (isReloading) return;

        if (Input.GetButton("Fire1") && Time.time >= lastFireTime + currentWeapon.fireRate)
        {
            if (currentAmmo > 0)
            {
                Shoot();
            lastFireTime = Time.time;
            currentAmmo--;
            }
            else
            {
                StartCoroutine(Reload());
            }
        
        }
    }

    private void FixedUpdate()
    {
        RotateToMouse();
    }

    private void Shoot()
    {
        for (int i = 0; i < currentWeapon.bulletsPerShot; i++)
        {
            float spreadOffset = currentWeapon.spreadAngle * (i - (currentWeapon.bulletsPerShot - 1) / 2f);
            Quaternion spreadRot = Quaternion.Euler(0, 0, spreadOffset);

            Vector2 shootDir = spreadRot * transform.right; // now aligned with mouse

            GameObject bullet = BulletPool.Instance.GetBullet();
            bullet.transform.position = transform.position;
            bullet.transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(shootDir.y, shootDir.x) * Mathf.Rad2Deg);
            bullet.SetActive(true);

            bullet.GetComponent<Bullet>().Fire(shootDir, currentWeapon.bulletSpeed);
        }
    }

    private IEnumerator Reload()
    {
        isReloading = true;
        yield return new WaitForSeconds(currentWeapon.reloadTime);
        currentAmmo = currentWeapon.magazineSize;
        isReloading = false;
        Debug.Log("Reloaded " + currentWeapon.weaponName);
    }

    private void RotateToMouse()
    {
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mouseWorld - transform.position);
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Rotate the player or weapon to face the mouse
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }

}
