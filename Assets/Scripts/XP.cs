using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XP : MonoBehaviour
{
    public static float XPamount;
    public static float goalXP;
    public Image XPbar;
    public Text XPText;
    public Text LevelText;

    public static int Level;

    public SuperPowerSelect superPowerSelect;


    // Start is called before the first frame update
    void Start()
    {
        goalXP = 20;
        XPamount = 0;

        Level = 1;

        superPowerSelect.Enable();
    } 

    // Update is called once per frame
    void Update()
    {
        LevelText.text = "Level:" + Level;
        if(XPamount >= goalXP)
        {
            SuperPowerSelect.IsStart = true;
            superPowerSelect.Enable();
            XPamount = 0;
            goalXP += 15;
            Level += 1;
        }
        XPbar.fillAmount = XPamount / goalXP;
        XPText.text = XPamount + "/" + goalXP;
    }
}
