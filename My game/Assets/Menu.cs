using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{ 
   



    // Start is called before the first frame update
    public void PlayAgain()
    {
        Application.LoadLevel("Level");
        
    }
    public void LaunchGameMenu()
    {
        Application.LoadLevel("GameMenu");
    }
}
