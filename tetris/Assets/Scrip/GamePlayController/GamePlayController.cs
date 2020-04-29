using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class GamePlayController : MonoBehaviour
{
    public void __PlayButton()
    {
        Application.LoadLevel("GamePlay");
        //SceneManager.LoadScene("Menu");
    }
}
