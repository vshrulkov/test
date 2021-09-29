using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    
public class Score : MonoBehaviour
{
    [SerializeField] Text HighScoreText;
    [SerializeField] Text ScoreText;

    public static float score;
    int highscore;

    void Start()
    {
        score = 0;

    }

    // Update is called once per frame
    void Update()
    {
        highscore = (int)score;
        ScoreText.text = "SCORE: " + highscore.ToString();
        if (PlayerPrefs.GetInt("score") <= highscore)
            PlayerPrefs.SetInt("score", highscore);
        HighScoreText.text = "HighScore: " + PlayerPrefs.GetInt("score").ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Score")
        {
            score++;
        }
    }


}
