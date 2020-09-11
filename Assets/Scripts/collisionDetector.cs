using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionDetector : MonoBehaviour
{
    public shooting shooting;
    public GameObject bullet;

    public static float bulletScale;
    // Start is called before the first frame update
    void Start()
    {
        bullet.transform.localScale = new Vector3(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
        bulletScale = bullet.transform.localScale.x;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            helf.Helf -= 1;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            helf.Helf -= 1;
        }


        if (collision.gameObject.tag == "Poison")
        {
            bool b = false;

            if(b == false)
            {
              InvokeRepeating("poisoning", 2f, 4f);
                b = true;
            }

        }

        if (collision.gameObject.tag == "EnemyBullet")
        {
            helf.Helf -= 2;
        }

        if (collision.gameObject.tag == "Ammo")
        {
            shooting.Ammo = shooting.FullAmmo;

        }

        if (collision.gameObject.tag == "healthUpgrade")
        {
            helf.Helf = helf.fullhelf;
        }

        if (collision.gameObject.tag == "health++")
        {
            helf.fullhelf += 1;
        }


        if (collision.gameObject.tag == "Upgrade")
        {
            shooting.FullAmmo += 5;

            shooting.Ammo = shooting.FullAmmo;

            
        }

        if (collision.gameObject.tag == "XPpoint")
        {
            XP.XPamount += 1f;


        }

        if (collision.gameObject.tag == "Upgrade2")
        {
            bullet.transform.localScale += new Vector3(0.7f, 0.7f, 0);
        }

        if(collision.gameObject.tag == "DamageUpgrade")
        {
            PlayerMovement.damage += 2;
            print(PlayerMovement.damage);
        }

        if (collision.gameObject.tag == "gun")
        {
            if (shooting.selectedWeapon != 1)
            {
                shooting.selectedWeapon = 1;
                GameObject g = collision.gameObject;
                Destroy(g, 0.01f);
                shooting.Ammo = shooting.FullAmmo;
            }
        }

        if (collision.gameObject.tag == "rocketLauncher")
        {
            if (shooting.selectedWeapon != 2)
            {
                shooting.selectedWeapon = 2;
                GameObject g = collision.gameObject;
                Destroy(g, 0.01f);
                shooting.Ammo = shooting.FullAmmo;
            }
        }

        if(collision.gameObject.tag == "Shotgun")
        {
            if(shooting.selectedWeapon != 3)
            {
                shooting.selectedWeapon = 3;
                GameObject g = collision.gameObject;
                Destroy(g, 0.01f);
                shooting.Ammo = shooting.FullAmmo;
            }
        }

        if (collision.gameObject.tag == "uzi")
        {
            if (shooting.selectedWeapon != 4)
            {
                shooting.selectedWeapon = 4;
                GameObject g = collision.gameObject;
                Destroy(g, 0.01f);
                shooting.Ammo = shooting.FullAmmo;
            }
        }
    }

    void poisoning()
    {
        int i = 10;

        if (i > 0)
        {
            
            helf.Helf -= 1;
            i -= 1;
        }

    }
}
