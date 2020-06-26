using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject MenuCanvas;

    void Update()
    {
        if (Input.GetKey("escape") || (Input.GetKey("joystick 1 button 9") || Input.GetKey("joystick 2 button 9")) ||
                                    (Input.GetKey("joystick 1 button 7") || Input.GetKey("joystick 2 button 7")))
        {
            MenuCanvas.SetActive(true);
            Time.timeScale = 0;
        }
    }

   public void onResumeBtn()
    {
        MenuCanvas.SetActive(false);
        Time.timeScale = 1;  
    }
   public  void onExitToMenuBtn()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;  

    }
   public void onExitToDesktopBtn()
    {
       Application.Quit();
    }
}
