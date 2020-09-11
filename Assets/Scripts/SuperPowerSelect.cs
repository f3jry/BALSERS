using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SuperPowerSelect : MonoBehaviour
{
    public Image icon1;
    public Image icon2;
    public Image icon3;

    public Sprite[] sprite;
    public static int SuperPower;

    public int maxint;

    public static bool isvecowned = false;

    int r;
    int rr;
    int rrr;

    public static bool IsStart;

    // Start is called before the first frame update
    void Start()
    {

    



    }

    // Update is called once per frame
    void Update()
    {

    }

    public void select1()
    {
        SuperPower = r;
        select();
    }

    public void select2()
    {
        SuperPower = rr;
        select();
    }

    public void select3()
    {
        SuperPower = rrr;
        select();
    }

    void select()
    {
        Disable();
        IsStart = false;

        if(SuperPower == 1)
        {
            helf.fullhelf += 6;
            helf.Helf = helf.fullhelf;
        }
        else if(SuperPower == 2)
        {
            PlayerMovement.damage += 7;
        }
        else if (SuperPower == 3)
        {
            PlayerMovement.speed = 0.05f;
        }
        else if (SuperPower == 4)
        {
            isvecowned = true;
        }
        else if (SuperPower == 5)
        {
            shooting.FullAmmo += 40;
            shooting.Ammo = shooting.FullAmmo;
        }
        else if (SuperPower == 6)
        {
            Enemy.scoreAmount += 0.3f;
        }
        else if (SuperPower == 7)
        {
            shooting.selectedWeapon = 4;
        }
        else if (SuperPower == 8)
        {
            PlayerMovement.speed = 0.005f;
            helf.fullhelf += 10;
            helf.Helf = helf.fullhelf;
            shooting.FullAmmo += 30;
            PlayerMovement.damage += 4;
            shooting.Ammo = shooting.FullAmmo;
            helf.Helf = helf.fullhelf;
        }
    }

    public void Enable()
    {
        gameObject.SetActive(true);
        
            r = Random.Range(1, maxint);
            rr = Random.Range(1, maxint);
            rrr = Random.Range(1, maxint);

            while (r == rr)
            {
                r = Random.Range(1, maxint);
                rr = Random.Range(1, maxint);
                rrr = Random.Range(1, maxint);
            }

            while (rr == rrr)
            {
                r = Random.Range(1, maxint);
                rr = Random.Range(1, maxint);
                rrr = Random.Range(1, maxint);
            }

            while (rrr == r)
            {
                r = Random.Range(1, maxint);
                rr = Random.Range(1, maxint);
                rrr = Random.Range(1, maxint);
            }

        if (r == 1)
        {
            icon1.sprite = sprite[0];
        }
        else if (r == 2)
        {
            icon1.sprite = sprite[1];
        }
        else if (r == 3)
        {
            icon1.sprite = sprite[2];
        }
        else if (r == 4)
        {
            icon1.sprite = sprite[3];
        }
        else if (r == 5)
        {
            icon1.sprite = sprite[4];
        }
        else if (r == 6)
        {
            icon1.sprite = sprite[5];
        }
        else if (r == 7)
        {
            icon1.sprite = sprite[6];
        }
        else if (r == 8)
        {
            icon1.sprite = sprite[7];
        }

        if (rr == 1)
        {
            icon2.sprite = sprite[0];
        }
        else if (rr == 2)
        {
            icon2.sprite = sprite[1];
        }
        else if (rr == 3)
        {
            icon2.sprite = sprite[2];
        }
        else if (rr == 4)
        {
            icon2.sprite = sprite[3];
        }
        else if (rr == 5)
        {
            icon2.sprite = sprite[4];
        }
        else if (rr == 6)
        {
            icon2.sprite = sprite[5];
        }
        else if (rr == 7)
        {
            icon2.sprite = sprite[6];
        }
        else if (rr == 8)
        {
            icon2.sprite = sprite[7];
        }


        if (rrr == 1)
        {
            //vic zivotu
            icon3.sprite = sprite[0];
        }
        else if (rrr == 2)
        {
            //
            icon3.sprite = sprite[1];
        }
        else if (rrr == 3)
        {
            icon3.sprite = sprite[2];
        }
        else if (rrr == 4)
        {
            icon3.sprite = sprite[3];
        }
        else if (rrr == 5)
        {
            icon3.sprite = sprite[4];
        }
        else if (rrr == 6)
        {
            icon3.sprite = sprite[5];
        }
        else if (rrr == 7)
        {
            icon3.sprite = sprite[6];
        }
        else if (rrr == 8)
        {
            icon3.sprite = sprite[7];
        }

    }

    public void Disable()
    {
        GameObject Startselect = GameObject.Find("sTARTsELECT");
        Startselect.SetActive(false);
    }
}
