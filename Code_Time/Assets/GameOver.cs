using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI EndGame;
    public TextMeshProUGUI HighScoreText;
    int score = 0;
    int highscore;
   
    void Start()
    {
        
        if(PlayerPrefs.HasKey("PersonalBest"))
        {
            highscore = PlayerPrefs.GetInt("PersonalBest");
            HighScoreText.text = "HighScore: " + highscore.ToString();
        }
        else
        {
            highscore = 0;
            PlayerPrefs.SetInt("PersonalBest", highscore);
            HighScoreText.text = "HighScore: " + PlayerPrefs.GetInt("PersonalBest");
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            score++;
            Debug.Log("Artıyor");
            if(score > highscore)
            {
                highscore = score;
                PlayerPrefs.SetInt("PersonalBest", highscore);
                HighScoreText.text = "HighScore: " + PlayerPrefs.GetInt("PersonalBest");
            }
        }
        EndGame.text = "Score:" + score.ToString();

    }
}
