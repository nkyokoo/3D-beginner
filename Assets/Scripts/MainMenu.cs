using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
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
   
   public void start2player()
   {
      if (Application.genuine)
      {
         try
         {
            SceneManager.LoadScene(2);

         }
         catch (Exception e)
         {
            Console.WriteLine(e);
            Application.Quit();

         }

      }

   }
   public void exitGame()
   {
      
      Application.Quit();
   }
}
