﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameEnding : MonoBehaviour
{
    public float fadeDuration = 1f;
    public GameObject player;
    public GameObject player2;
    public CanvasGroup ExitBackgroundImageCanvasGroup;
    public CanvasGroup P1_CaughtBackgroundImageCanvasGroup;
    public CanvasGroup P2_CaughtBackgroundImageCanvasGroup;
    public float displayImageDuration = 1f;
    public AudioSource exitAudio;
    public AudioSource caughtAudio;
    public Transform SpawnPoint;


     GameObject targetPlayer = null;
    bool m_IsPlayerAtExit;
    bool m_IsPlayerCaught;
    float m_Timer;
    bool m_HasAudioPlayed;


    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject == player ||  other.gameObject == player2)
        { 
            m_IsPlayerAtExit = true;

        }

    }
    public void CaughtPlayer (GameObject targetPlayer)
    {
        this.targetPlayer = targetPlayer;
        m_IsPlayerCaught = true;
    }
    void Update()
    {
        if(m_IsPlayerAtExit)
        {
        
            EndLevel(ExitBackgroundImageCanvasGroup, false, exitAudio, targetPlayer);
            
        }  
        else if(m_IsPlayerCaught)
        {


            if (targetPlayer == player)
            {
                EndLevel(P1_CaughtBackgroundImageCanvasGroup, true, exitAudio, targetPlayer);

            }
            else if (targetPlayer == player2)
            {
                EndLevel(P2_CaughtBackgroundImageCanvasGroup, true, exitAudio, targetPlayer);

            }
              
                  
            
        }
        
        
    }
    void EndLevel (CanvasGroup imageCanvasGroup, bool doRestart, AudioSource audioSource, GameObject Player) 
    {
        m_Timer += Time.deltaTime;
        imageCanvasGroup.alpha = m_Timer / fadeDuration;
        if(m_Timer > fadeDuration + displayImageDuration)
        {
            if (doRestart)
            {
                if (SceneManager.GetActiveScene().buildIndex == 2)
                {
                    Player.transform.position = SpawnPoint.transform.position;
                    imageCanvasGroup.alpha = 0;
                    m_IsPlayerCaught = false;

                }
                else
                {

                    SceneManager.LoadScene(1);

                }

            }
            else
            {
                if (SceneManager.GetActiveScene().buildIndex == 2)
                { 
                    Time.timeScale = 0;
                    GameObject Text = imageCanvasGroup.transform.Find("PlayerMessage").gameObject;
                   Text.GetComponent<Text>().text = $"{targetPlayer.name} won!"; 

                }
                else
                {
                    Time.timeScale = 0;
                }
                
            }

        }
        if(!m_HasAudioPlayed)
        {
            audioSource.Play();
            m_HasAudioPlayed = true;


        }
    }
}
