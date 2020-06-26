using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    public Transform player;
    public Transform player2;
    public GameEnding gameEnding;
    
    private GameObject targetPlayer;
    bool m_IsPlayerInRange;


    void OnTriggerEnter(Collider other)
    {
        if (other.transform == player || other.transform == player2)
        {
            targetPlayer = other.gameObject;
            m_IsPlayerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform == player || other.transform == player2)
        {
            m_IsPlayerInRange = false;
        }
    }


    void Update()
    {
        if (m_IsPlayerInRange)
        {
            Vector3 direction = player.position - transform.position + Vector3.up;
            Ray ray = new Ray (transform.position, direction);
            RaycastHit raycastHit;

            if(Physics.Raycast(ray, out raycastHit))
            {
                if(raycastHit.collider.transform == player)
                {
                    Debug.Log(raycastHit.collider.transform);
                    Debug.Log(raycastHit);
                    gameEnding.CaughtPlayer(targetPlayer);

                }
            }
        }
    }
}