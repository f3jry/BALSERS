using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        SuperPowerSelect.IsStart = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.M))
        {
            SceneManager.LoadScene("Menu");
        }
    }

    public void Play()
    {
        SceneManager.LoadScene("Game");
        helf.Isdead = false;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Meny()
    {
        SceneManager.LoadScene("Menu");
    }

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

}
