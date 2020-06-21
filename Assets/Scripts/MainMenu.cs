using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public GameObject mainMenuCanvas;
   public GameObject multiplayerMenuCanvas;
   public void startSingePlayer()
   {
      if (Application.genuine)
      {
         try
         {
            SceneManager.LoadScene(1);

         }
         catch (Exception e)
         {
            Console.WriteLine(e);
            Application.Quit();

         }

      }
   }
   
   public void showMultiplayerMenu()
   {
      mainMenuCanvas.SetActive(false);
      multiplayerMenuCanvas.SetActive(true);

   }
   public void exitGame()
   {
      
      Application.Quit();
   }
}
