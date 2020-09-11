using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_range : MonoBehaviour
{
    public Enemy Enemy;

    public bool isInRange;
    public Transform enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = enemy.transform.position;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isInRange = true;
        }
        else
        {
            isInRange = false;
        }
    }
}
