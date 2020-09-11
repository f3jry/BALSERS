using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static int damage;

    Vector3 mousepos;
    public static float speed = 0.02f;
    public Rigidbody2D rb;
    Vector2 pos = new Vector2(0f, 0f);
    public float dashSpeed;


    // Start is called before the first frame update 
    void Start()
    {
        speed = 0.03f;
        damage = 5;
    }

    // Update is called once per frame
    private void Update()
    {
        //if (UImanager.GameIsPaused == false)
        //{
            //Time.timeScale = 0;
            mousepos = Input.mousePosition;
            mousepos = Camera.main.ScreenToWorldPoint(mousepos);
            pos = Vector2.Lerp(transform.position, mousepos, speed);

            Vector2 direction = new Vector2(mousepos.x - transform.position.x, mousepos.y - transform.position.y);

            transform.up = direction;

            if (Time.timeScale == 0)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    // Time.timeScale = 1;
                }
            }
        //}


    }

    private void FixedUpdate()
    {
        Vector3 LastPos;
       
        if (Input.GetMouseButton(1))
        {
            TimeManager.slou();
            rb.constraints = RigidbodyConstraints2D.FreezePosition;

        }
        else
        {
            LastPos = transform.position;
            rb.MovePosition(pos);
            TimeManager.timeFull();
            rb.constraints = RigidbodyConstraints2D.None;

        }

    }
}
