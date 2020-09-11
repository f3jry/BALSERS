using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject Exp;
    public Shake shake;

    public GameObject hitEffect;

    public bool isEnem;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isEnem == false)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                if (shooting.selectedWeapon == 2)
                {
                    Instantiate(Exp, transform.position, Quaternion.Euler(0, 0, Random.Range(1, 360)));
                    //StartCoroutine(shake.shake(1.15f,1.4f)) ;
                }
                Destroy(gameObject, 0.005f);
                Instantiate(hitEffect, transform.position, Quaternion.Euler(0, 0, Random.Range(1, 360)));
            }
        }

        if (isEnem == true)
        {
            if (collision.gameObject.tag == "Player")
            {
                Destroy(gameObject, 0.005f);
                Instantiate(hitEffect, transform.position, Quaternion.Euler(0, 0, Random.Range(1, 360)));
            }
        }

        if (collision.gameObject.tag == "Wall")
        {
            if (shooting.selectedWeapon == 2)
            {
                Instantiate(Exp, transform.position, Quaternion.Euler(0, 0, Random.Range(1, 360)));
            }
            Destroy(gameObject, 0.005f);
            Instantiate(hitEffect, transform.position, Quaternion.Euler(0, 0, Random.Range(1, 360)));
        }
    }
}
