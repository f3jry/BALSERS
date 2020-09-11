using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float StartHP = 30, HP;
    new SpriteRenderer renderer;
    public Color[] color;

    public GameObject bulletPrefab;
    public float bulletSpeed;

    Transform Player;
    public float speed = 1;
    Rigidbody2D rb;
    Vector2 movement;
    GameObject player;

    public int canShoot;

    public Image hpBar;
    public Transform helfBarEnem;

    public static float scoreAmount = 1;

    bool bol = false;


    public float radius;
    GameObject DeathEffect;

    public bool IsPois;
    public GameObject poison;

    // Start is called before the first frame update
    void Start()
    {
        bulletSpeed = Random.Range(4, 12);
        canShoot = (Random.Range(0, 2));
        player = GameObject.Find("Player");

        HP = StartHP;

        Player = player.GetComponent<Transform>(); 

        renderer = GetComponent<SpriteRenderer>();
        rb = this.GetComponent<Rigidbody2D>();

        DeathEffect = GameObject.Find("DieEffectEnem");

    }

    // Update is called once per frame
    void Update()
    {
        helfBarEnem.transform.rotation = Quaternion.identity;
        hpBar.fillAmount = HP / StartHP;
        //print(distance);


        //print(HP);
        if (HP <= 0)
        {
            Die();
        }

        if (HP <= 50 && HP > 40)
        {
            renderer.color = color[4];
        }
        else if (HP == 40 && HP > 30)
        {
            renderer.color = color[3];


        }
        else if (HP == 30 && HP > 20)
        {
            renderer.color = color[2];
        }
        else if (HP == 20 && HP > 10)
        {
            renderer.color = color[1];
        }
        else if (HP == 10 && HP > 0)
        {
            renderer.color = color[0];
        }

        Vector3 direction = Player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;

    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    }

    private void FixedUpdate()
    {
        bool dawuka = false;
        float nextTimeToFire= 1;
        float fireRate = 4;

        float distance = Vector3.Distance(transform.position, Player.transform.position);

        if (distance <= radius)
        {
            if (UImanager.GameIsPaused == false)
            {
                //print("gg");
                moveCharacter(movement);

                nextTimeToFire = Time.time + 1f / fireRate;


                if (dawuka == false)
                {
                    dawuka = true;
                    //InvokeRepeating("shoot", 1, 1);
                }
                else
                {
                    dawuka = true;
                }

            }

            if (canShoot == 1)
            {

                if (bol == false)
                {
                    bol = true;

                    InvokeRepeating("shoot", 2, Random.Range(1, 4));
                }
            }



        }

        

            
  
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (UImanager.GameIsPaused == false)
        //{
            if (collision.gameObject.tag == "Bullet")
            {
                if (shooting.selectedWeapon == 1)
                {
                    HP -= PlayerMovement.damage;
                }
                else if (shooting.selectedWeapon == 3)
                {
                    HP -= PlayerMovement.damage;
                }
                else if (shooting.selectedWeapon == 4)
                {
                    HP -= PlayerMovement.damage;
                }


            }

            if (collision.gameObject.tag == "explositon")
            {
                HP -= PlayerMovement.damage * 5;
            }
        //}

    }

    void Die()
    {
        Destroy(gameObject, 0.01f);
        Instantiate(DeathEffect, transform.position, Quaternion.identity);
        Score.score += scoreAmount;


        if(IsPois == true)
        {
            Instantiate(poison, transform.position, Quaternion.identity);
        }
    }

    void shoot()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);
        if (distance <= radius)
        {
            GameObject bullet1 = Instantiate(bulletPrefab, transform.position, transform.rotation);
            Rigidbody2D rb1 = bullet1.GetComponent<Rigidbody2D>();
            rb1.AddForce(transform.right * bulletSpeed, ForceMode2D.Impulse);
        }
    }
}
