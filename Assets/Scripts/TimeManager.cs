using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    private void Start()
    {
        Stop();
    }
    public static void Stop()
    {
        Time.timeScale = 0f;
    }

    public static void timeFull()
    {

        Time.timeScale = 1;
    }

    public static void slou()
    {
        Time.timeScale = 0.7f;
    }

    public static void megaslou()
    {

        Time.timeScale = 0.4f;
    }

    private void Update()
    {

        if (UImanager.GameIsPaused == true)
        {
            TimeManager.Stop();

        }
        else
        {
            if (SuperPowerSelect.IsStart == false)
            {
                if (helf.Isdead == false)
                {
                    TimeManager.timeFull();
                }
                else
                {
                    TimeManager.slou();
                }
            }
            else
            {
                TimeManager.Stop();
            }

        }
    }
}
