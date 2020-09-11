using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject rocketPrefab;
    public GameObject uziBulletPrefab;
    public float bulletSpeed;

    public float fireRate;

    public float fireRateuzi;
    public float fireRategun;
    public float fireRateshotgun;
    public float fireRateexp;
    float nexttimetofire = 0;

    public Text AmmoText;
    public static float Ammo;
    public static float FullAmmo = 20;

    public static int selectedWeapon;

    public GameObject gun;
    public GameObject rocketLauncher;
    public GameObject uzi;

    public Transform dir1;
    public Transform dir2;
    public Transform dir3;
    public Transform dir4;
    public Transform dir5;
    public Transform dir6;

    float A1;

    public float bulletspeedShotgun;
    public float bulletspeedrocketLaunchern;

    // Start is called before the first frame update
    void Start()
    {


        FullAmmo = 40;
        Ammo = FullAmmo;
        selectedWeapon = 1;
    }

    // Update is called once per frame
    void Update()
    {
        AmmoText.text = Ammo + "/" + FullAmmo;
        if (Input.GetMouseButton(0) && Time.time >= nexttimetofire)
        {

            print("kakos polni");
            if (Ammo >= A1)
            {
                if (selectedWeapon == 1)
                {
                    shoot();
                    fireRate = fireRategun;
                    A1 = 2;
                    Ammo -= A1;
                }
                else if (selectedWeapon == 2)
                {
                    shootRocket();
                    fireRate = fireRateexp;
                    A1 = 10;
                    Ammo -= A1;
                }
                else if (selectedWeapon == 3)
                {
                    shotgunshoot();
                    fireRate = fireRateshotgun;
                    A1 = 6;
                    Ammo -= A1;
                }
                else if (selectedWeapon == 4)
                {
                    shootUzi();
                    fireRate = fireRateuzi;
                    A1 = 1;
                    Ammo -= A1;
                }

                nexttimetofire = Time.time + 1f / fireRate;
            }
        }


      
    }

    void shoot()
    {
        GameObject bullet1 = Instantiate(bulletPrefab, transform.position, transform.rotation);
        Rigidbody2D rb1 = bullet1.GetComponent<Rigidbody2D>();
        rb1.AddForce(transform.up * bulletSpeed, ForceMode2D.Impulse);
    }

    void shootUzi()
    {
        GameObject bullet1 = Instantiate(uziBulletPrefab, transform.position, transform.rotation);
        Rigidbody2D rb1 = bullet1.GetComponent<Rigidbody2D>();
        rb1.AddForce(transform.up * bulletSpeed, ForceMode2D.Impulse);
    }

    void shotgunshoot()
    {
        Vector2 direction1 = new Vector2(dir1.position.x - transform.position.x, dir1.position.y - transform.position.y);
        Vector2 direction2 = new Vector2(dir2.position.x - transform.position.x, dir2.position.y - transform.position.y);
        Vector2 direction3 = new Vector2(dir3.position.x - transform.position.x, dir3.position.y - transform.position.y);
        Vector2 direction4 = new Vector2(dir4.position.x - transform.position.x, dir4.position.y - transform.position.y);
        Vector2 direction5 = new Vector2(dir5.position.x - transform.position.x, dir5.position.y - transform.position.y);
        Vector2 direction6 = new Vector2(dir6.position.x - transform.position.x, dir6.position.y - transform.position.y);
        GameObject bullet1 = Instantiate(bulletPrefab, transform.position, transform.rotation);
        GameObject bullet2 = Instantiate(bulletPrefab, transform.position, transform.rotation);
        GameObject bullet3 = Instantiate(bulletPrefab, transform.position, transform.rotation);
        GameObject bullet4 = Instantiate(bulletPrefab, transform.position, transform.rotation);
        GameObject bullet5 = Instantiate(bulletPrefab, transform.position, transform.rotation);
        GameObject bullet6 = Instantiate(bulletPrefab, transform.position, transform.rotation);
        Rigidbody2D rb1 = bullet1.GetComponent<Rigidbody2D>();
        Rigidbody2D rb2 = bullet2.GetComponent<Rigidbody2D>();
        Rigidbody2D rb3 = bullet3.GetComponent<Rigidbody2D>();
        Rigidbody2D rb4 = bullet4.GetComponent<Rigidbody2D>();
        Rigidbody2D rb5 = bullet5.GetComponent<Rigidbody2D>();
        Rigidbody2D rb6 = bullet6.GetComponent<Rigidbody2D>();
        rb1.AddForce(direction1 * bulletspeedrocketLaunchern, ForceMode2D.Impulse);
        rb2.AddForce(direction2 * bulletspeedrocketLaunchern, ForceMode2D.Impulse);
        rb3.AddForce(direction3 * bulletspeedrocketLaunchern, ForceMode2D.Impulse);
        rb4.AddForce(direction4 * bulletspeedrocketLaunchern, ForceMode2D.Impulse);
        rb5.AddForce(direction5 * bulletspeedrocketLaunchern, ForceMode2D.Impulse);
        rb6.AddForce(direction6 * bulletspeedrocketLaunchern, ForceMode2D.Impulse);
    }

    void shootRocket()
    {
        GameObject bullet = Instantiate(rocketPrefab, transform.position, transform.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * bulletspeedrocketLaunchern, ForceMode2D.Impulse);
    }

}

