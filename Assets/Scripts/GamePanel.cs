﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePanel : MonoBehaviour
{
   
  public void PlayGame()
   {
      SceneManager.LoadScene(("Level01"));
   }

  public void QuitGame()
   {
      Application.Quit();
   }
}
