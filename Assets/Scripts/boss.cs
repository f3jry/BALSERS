using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boss : MonoBehaviour
{
    public int StartHP = 30, HP;
    new SpriteRenderer renderer;
    public Color[] color;

    Transform Player;
    public float speed = 1;
    Rigidbody2D rb;
    Vector2 movement;
    GameObject player;

    public Image hpBar;
    public Transform helfBarEnem;

    public float radius;
    GameObject DeathEffect;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");


        Player = player.GetComponent<Transform>();
        HP = StartHP;

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

        if (HP == 50)
        {
            renderer.color = color[4];
        }
        else if (HP == 40)
        {
            renderer.color = color[3];
        }
        else if (HP == 30)
        {
            renderer.color = color[2];
        }
        else if (HP == 20)
        {
            renderer.color = color[1];
        }
        else if (HP == 10)
        {
            renderer.color = color[0];
        }

        Vector3 direction = Player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        direction.Normalize();
        movement = direction;

    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    }

    private void FixedUpdate()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);

        if (distance <= radius)
        {
            //print("gg");
            moveCharacter(movement);
        }


    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            HP -= PlayerMovement.damage;

        }
        if (collision.gameObject.tag == "explositon")
        {
            print("zaba");
            HP -= PlayerMovement.damage * 5;
        }

    }

    void Die()
    {
        Destroy(gameObject);
        Instantiate(DeathEffect, transform.position, Quaternion.identity);
        Score.score += 1;
    }
}
