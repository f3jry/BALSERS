using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class helf : MonoBehaviour
{
    public Collider2D player;
    public GameObject playerG;

    public static float Helf;
    public static float fullhelf;

    public GameObject desthEffect;

    public GameObject deathscreen;

    public Image helthBar;

    public Text helfText;

    bool kakat = false;

    public GameObject defvec;
    public static bool Isdead;
    // Start is called before the first frame update
    void Start()
    {
        fullhelf = 15;
        Helf = fullhelf;
        Isdead = false;
        kakat = false;
        SuperPowerSelect.isvecowned = false;


    }

    // Update is called once per frame
    void Update()
    {
        if(Isdead == true)
        {
            deathscreen.gameObject.SetActive(true);
        }
        else
        {
            deathscreen.gameObject.SetActive(false);
        }
        helthBar.fillAmount = Helf/fullhelf;

        helfText.text = Helf + " / " + fullhelf;

        if(Helf <= 0)
        {
            if(kakat == false)
            {
                kakat = true;
                Die();
            }
        }
    }


    void Die()
    {
        print(kakat);
        Isdead = true;
        Instantiate(desthEffect, player.transform.position, Quaternion.identity);
        if(SuperPowerSelect.isvecowned == true)
        {
            Instantiate(defvec, player.transform.position, Quaternion.identity);
        }
        Destroy(playerG, 0.001f);

    }
}
