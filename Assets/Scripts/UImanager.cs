using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    public Text damgeText;
    public Text ScaleText;


    public Image ammoBar;

    public GameObject Deathscreen;
    public GameObject pauseMenu;
    public GameObject startSelect;

    public GameManager gameManager;

    public static bool GameIsPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.gameObject.SetActive(false);
        Deathscreen.gameObject.SetActive(false);
        startSelect.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        float i = shooting.Ammo/shooting.FullAmmo;

        ammoBar.fillAmount = i;
        if (GameIsPaused == true)
        {
            pauseMenu.gameObject.SetActive(true);

        }
        else
        {
            pauseMenu.gameObject.SetActive(false);


        }

        damgeText.text = PlayerMovement.damage.ToString();
        ScaleText.text = collisionDetector.bulletScale.ToString();

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused == true)
            {
                GameIsPaused = false;
            }
            else
            {
                GameIsPaused = true;
            }

        }

        

        

    }


    public void resume()
    {
        pauseMenu.gameObject.SetActive(false);
        TimeManager.timeFull();
        GameIsPaused = false;
    }
}
