using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public ParticleSystem CollectEffect;
    public GameObject collectEffect;
    public Color color;
    private void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            CollectEffect.startColor = color;
            Instantiate(collectEffect, transform.position, Quaternion.identity);

        }
    }
}
