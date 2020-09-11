using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    public Text highScoreText;
    public static float score;
    public static float highscore;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;

        highscore = PlayerPrefs.GetFloat("hs");
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = score.ToString();
        highScoreText.text = highscore.ToString();

        if (score >= highscore)
        {
            highscore = score;
            PlayerPrefs.SetFloat("hs", highscore);
        }
    }
}
