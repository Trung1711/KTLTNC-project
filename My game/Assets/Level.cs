using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    public static bool startinglevelZero;
    public static int startingLevel;

    // Start is called before the first frame update
    public static int currentLevel = 0;
    public static int numberClearLine = 0;
    public Text hud_level;
    public  Text hud_line;
     void Start()
    {

        currentLevel = startingLevel;
    }
 

    // Update is called once per frame
    void Update()
    {
        UpdateLevel();
        UpdateSpeed();
        UILevel();
        UILine();
        
    }
    public void UpdateLevel()
    {
        if((startinglevelZero==true)||startinglevelZero==false && numberClearLine/2 >startingLevel)
        
        currentLevel = numberClearLine / 2;
       
    }
    public void UpdateSpeed()
    {
        TertrisBlock1.fallTime = 1.0f - ((float)currentLevel * 0.1f);
      }
    public void UILevel()
    {
        hud_level.text = currentLevel.ToString();
    }
    public void UILine()
    {
        hud_line.text = numberClearLine.ToString();
    }
}
