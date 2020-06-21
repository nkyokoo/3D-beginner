using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MultiplayerMenu : MonoBehaviour
{

    public GameObject mainMenuCanvas;
    public GameObject multiplayerMenuCanvas;
    
    public void startMultiPlayer()
    {
        if (Application.genuine)
        {
       
        }
    }
   
    public void joinMultiplayer()
    
    {
      
    }
    public void backToMainMenu()
    {
      
        mainMenuCanvas.SetActive(true);
        multiplayerMenuCanvas.SetActive(false);

    }
}
