﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class menumanager : MonoBehaviour
{
    public void StartGame()
    {
        print ("開始遊戲");
        SceneManager.LoadScene("關卡1");
    }
    public void QuuitGame()
    {
       print ("離開遊戲");
        Application.Quit();
    }
}