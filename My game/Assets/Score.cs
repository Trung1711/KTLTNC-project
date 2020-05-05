using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public int scoreOneLine = 5;
    public int scoreTwoLine = 10;
    public int scoreThreeLine = 15;
    public int scoreFourLine = 20;
    public static int numberOfRowThisTurn = 0;
    public  Text hud_score;
    public  int currentScore = 0;
    private int startingHighscore;
     void Start()
    { 
        startingHighscore = PlayerPrefs.GetInt("highscore");
    }
    
 
    void Update()
    {
        UpdateScore();
        UpdateUI();
        UpdateHighscore();
        
    }
    // Start is called before the first frame update
    // Update is called once per frame

    public void UpdateUI()
    {
        hud_score.text = currentScore.ToString();
    }
    public void UpdateScore()
    {
        if (numberOfRowThisTurn > 0)
        {
            if (numberOfRowThisTurn == 1)
            {
                currentScore = currentScore + scoreOneLine;
                Level.numberClearLine++;
            }

            else if (numberOfRowThisTurn == 2)
            {
                currentScore = currentScore + scoreTwoLine;
                Level.numberClearLine += 2;
            }

            else if (numberOfRowThisTurn == 3)
            {
                currentScore = currentScore + scoreThreeLine;
                Level.numberClearLine += 3;
            }

            else if (numberOfRowThisTurn == 4)
            {
                currentScore = currentScore + scoreFourLine;
                Level.numberClearLine += 4;

            }
            numberOfRowThisTurn = 0;
            UpdateHighscore();


        }
    }
    public void UpdateHighscore()
    {
        if(currentScore> startingHighscore)
        {
            PlayerPrefs.SetInt("highscore", currentScore);
        }
    }
  
    
}
  





