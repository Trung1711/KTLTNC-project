using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{
    public Text levelText;
    public Text highscoretext;
    // Start is called before the first frame update
    void Start()
    {
        levelText.text = "0";
        
        highscoretext.text = PlayerPrefs.GetInt("highscore").ToString();
    }

    // Update is called once per frame
    
  public void PlayGame()
    {
        if(Level.startingLevel== 0)
        {
            Level.startinglevelZero = true;
        }
        else
        {
            Level.startinglevelZero = false;
        }
        Application.LoadLevel("Level");
    }
    public void ChangeValue(float value)
    {
        Level.startingLevel = (int)value;
        levelText.text = value.ToString();
    }
    public void LaunchGameMenu()
    {
        Application.LoadLevel("GameMenu");
    }
}
